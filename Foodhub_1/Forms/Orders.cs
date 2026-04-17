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
            if (orderItemsTable.Rows.Count == 0)
            {
                MessageBox.Show("Please add at least one food item.");
                return;
            }

            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                con.Open();
                SqlTransaction trans = con.BeginTransaction();

                try
                {
                    string insertOrder = @"INSERT INTO Orders
                                          (CustomerID, OrderDate, OrderTime, OrderStatus, PaymentMethod, OrderAmount)
                                          OUTPUT INSERTED.OrderNo
                                          VALUES
                                          (@CustomerID, @OrderDate, @OrderTime, @OrderStatus, @PaymentMethod, @OrderAmount)";

                    SqlCommand cmdOrder = new SqlCommand(insertOrder, con, trans);
                    cmdOrder.Parameters.AddWithValue("@CustomerID", cmbCustomer.SelectedValue);
                    cmdOrder.Parameters.AddWithValue("@OrderDate", dtpOrderDate.Value.Date);
                    cmdOrder.Parameters.AddWithValue("@OrderTime", dtpOrderTime.Value.TimeOfDay);
                    cmdOrder.Parameters.AddWithValue("@OrderStatus", cmbOrderStatus.Text);
                    cmdOrder.Parameters.AddWithValue("@PaymentMethod", cmbPaymentMethod.Text);
                    cmdOrder.Parameters.AddWithValue("@OrderAmount", decimal.Parse(lblTotalAmount.Text));

                    int orderNo = (int)cmdOrder.ExecuteScalar();

                    foreach (DataRow row in orderItemsTable.Rows)
                    {
                        string insertItem = @"INSERT INTO OrderItem
                                             (OrderNo, ItemNumber, Quantity, UnitPriceAtOrderTime)
                                             VALUES
                                             (@OrderNo, @ItemNumber, @Quantity, @UnitPriceAtOrderTime)";

                        SqlCommand cmdItem = new SqlCommand(insertItem, con, trans);
                        cmdItem.Parameters.AddWithValue("@OrderNo", orderNo);
                        cmdItem.Parameters.AddWithValue("@ItemNumber", row["ItemNumber"]);
                        cmdItem.Parameters.AddWithValue("@Quantity", row["Quantity"]);
                        cmdItem.Parameters.AddWithValue("@UnitPriceAtOrderTime", row["UnitPriceAtOrderTime"]);
                        cmdItem.ExecuteNonQuery();
                    }

                    trans.Commit();
                    MessageBox.Show("Order saved successfully.");
                    orderItemsTable.Rows.Clear();
                    UpdateTotal();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            orderItemsTable.Rows.Clear();
            UpdateTotal();
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
            DataTable dt = DatabaseHelper.GetDataTable("SELECT CustomerID, CustomerName FROM Customer");
            cmbCustomer.DataSource = dt;
            cmbCustomer.DisplayMember = "CustomerName";
            cmbCustomer.ValueMember = "CustomerID";
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
    }
}
