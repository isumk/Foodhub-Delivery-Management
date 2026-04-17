using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodhub_1
{
    public partial class FrmOrders : Form
    {
        private DataTable orderItemsTable = new DataTable();
        public FrmOrders()
        {
            InitializeComponent();
        }
        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpOrderHeader_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (cmbFoodItem.SelectedValue == null) return;

            int itemNumber = Convert.ToInt32(cmbFoodItem.SelectedValue);
            string itemName = cmbFoodItem.Text;
            int qty = (int)numQuantity.Value;
            decimal unitPrice = decimal.Parse(txtUnitPrice.Text);

            orderItemsTable.Rows.Add(itemNumber, itemName, qty, unitPrice);
            UpdateTotal();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvOrderItems.CurrentRow != null)
            {
                dgvOrderItems.Rows.RemoveAt(dgvOrderItems.CurrentRow.Index);
                UpdateTotal();
            }

        }
        private void UpdateTotal()
        {
            decimal total = 0;
            foreach (DataRow row in orderItemsTable.Rows)
            {
                total += Convert.ToDecimal(row["LineAmount"]);
            }
            lblTotalAmount.Text = total.ToString("0.00");
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            if (!ValidateOrder()) return;

            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                con.Open();
                SqlTransaction trans = con.BeginTransaction();

                try
                {
                    int customerId;
                    if (!int.TryParse(cmbCustomer.SelectedValue?.ToString(), out customerId))
                    {
                        MessageBox.Show("Customer selection is invalid.");
                        return;
                    }

                    int orderNo;

                    using (SqlCommand cmdOrder = new SqlCommand(@"
                INSERT INTO Orders
                (CustomerID, OrderDate, OrderTime, OrderStatus, PaymentMethod, OrderAmount)
                OUTPUT INSERTED.OrderNo
                VALUES
                (@CustomerID, @OrderDate, @OrderTime, @OrderStatus, @PaymentMethod, @OrderAmount)", con, trans))
                    {
                        cmdOrder.Parameters.AddWithValue("@CustomerID", customerId);
                        cmdOrder.Parameters.AddWithValue("@OrderDate", dtpOrderDate.Value.Date);
                        cmdOrder.Parameters.Add("@OrderTime", SqlDbType.Time).Value = dtpOrderTime.Value.TimeOfDay;
                        cmdOrder.Parameters.AddWithValue("@OrderStatus", cmbOrderStatus.Text.Trim());
                        cmdOrder.Parameters.AddWithValue("@PaymentMethod", cmbPaymentMethod.Text.Trim());
                        cmdOrder.Parameters.AddWithValue("@OrderAmount", Convert.ToDecimal(lblTotalAmount.Text));

                        orderNo = Convert.ToInt32(cmdOrder.ExecuteScalar());
                    }

                    foreach (DataRow row in orderItemsTable.Rows)
                    {
                        using (SqlCommand cmdItem = new SqlCommand(@"
                    INSERT INTO OrderItem
                    (OrderNo, ItemNumber, Quantity, UnitPriceAtOrderTime)
                    VALUES
                    (@OrderNo, @ItemNumber, @Quantity, @UnitPriceAtOrderTime)", con, trans))
                        {
                            cmdItem.Parameters.AddWithValue("@OrderNo", orderNo);
                            cmdItem.Parameters.AddWithValue("@ItemNumber", Convert.ToInt32(row["ItemNumber"]));
                            cmdItem.Parameters.AddWithValue("@Quantity", Convert.ToInt32(row["Quantity"]));
                            cmdItem.Parameters.AddWithValue("@UnitPriceAtOrderTime", Convert.ToDecimal(row["UnitPriceAtOrderTime"]));

                            cmdItem.ExecuteNonQuery();
                        }
                    }

                    trans.Commit();
                    MessageBox.Show("Order saved successfully. Order No: " + orderNo);
                   
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Error: " + ex.ToString());
                }
            }
        }

        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            orderItemsTable.Rows.Clear();
            UpdateTotal();
            cmbPaymentMethod.SelectedIndex = -1;
            cmbOrderStatus.SelectedIndex = -1;
            numQuantity.Value = 1;
        }

        private void FrmOrders_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadFoodItems();

            cmbPaymentMethod.Items.AddRange(new string[] { "Cash", "Card", "Online" });
            cmbOrderStatus.Items.AddRange(new string[] { "Pending", "Preparing", "Dispatched", "Delivered", "Cancelled" });

            orderItemsTable.Columns.Add("ItemNumber", typeof(int));
            orderItemsTable.Columns.Add("ItemName", typeof(string));
            orderItemsTable.Columns.Add("Quantity", typeof(int));
            orderItemsTable.Columns.Add("UnitPriceAtOrderTime", typeof(decimal));
            orderItemsTable.Columns.Add("LineAmount", typeof(decimal), "Quantity * UnitPriceAtOrderTime");

            dgvOrderItems.DataSource = orderItemsTable;
        }
        private void LoadCustomers()
        {
            DataTable dt = DatabaseHelper.GetDataTable(
                "SELECT CustomerID, CustomerName FROM Customer ORDER BY CustomerName");

            cmbCustomer.DataSource = null;
            cmbCustomer.Items.Clear();

            cmbCustomer.DisplayMember = "CustomerName";
            cmbCustomer.ValueMember = "CustomerID";
            cmbCustomer.DataSource = dt;
            cmbCustomer.SelectedIndex = -1;
            cmbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LoadFoodItems()
        {
            DataTable dt = DatabaseHelper.GetDataTable("SELECT ItemNumber, ItemName, Price FROM FoodItem");
            cmbFoodItem.DataSource = dt;
            cmbFoodItem.DisplayMember = "ItemName";
            cmbFoodItem.ValueMember = "ItemNumber";
        }

        private void cmbFoodItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFoodItem.SelectedItem is DataRowView row)
            {
                txtUnitPrice.Text = row["Price"].ToString();
            }
        }
        private bool ValidateOrder()
        {
            if (cmbCustomer.SelectedIndex == -1 || cmbCustomer.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid customer.");
                return false;
            }

            int tempCustomerId;
            if (!int.TryParse(cmbCustomer.SelectedValue.ToString(), out tempCustomerId))
            {
                MessageBox.Show("Customer selection is invalid.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbPaymentMethod.Text))
            {
                MessageBox.Show("Please select a payment method.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbOrderStatus.Text))
            {
                MessageBox.Show("Please select an order status.");
                return false;
            }

            if (orderItemsTable.Rows.Count == 0)
            {
                MessageBox.Show("Please add at least one food item.");
                return false;
            }

            return true;
        }
    }
}
