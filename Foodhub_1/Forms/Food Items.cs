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
    public partial class FrmFoodItems : Form
    {
        public FrmFoodItems()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmFoodItems_Load(object sender, EventArgs e)
        {
            cmbCategory.Items.AddRange(new string[] { "Burger", "Pizza", "Sides", "Drinks", "Dessert" });
            LoadFoodItems();
        }
        private void LoadFoodItems()
        {
            dgvFoodItems.DataSource = DatabaseHelper.GetDataTable("SELECT * FROM FoodItem ORDER BY ItemNumber DESC");
        }
      

        private void btnSave_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO FoodItem (ItemName, ItemCategory, Price)
                             VALUES (@ItemName, @ItemCategory, @Price)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@ItemName", txtItemName.Text.Trim()),
                new SqlParameter("@ItemCategory", cmbCategory.Text),
                new SqlParameter("@Price", decimal.Parse(txtPrice.Text))
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
            MessageBox.Show("Food item saved.");
            LoadFoodItems();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtItemNumber.Text, out int itemNumber))
            {
                MessageBox.Show("Please select a valid food item from the list.");
                return;
            }
            
            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Price must be a valid number.");
                return;
            }

            string query = @"UPDATE FoodItem
                             SET ItemName=@ItemName, ItemCategory=@ItemCategory, Price=@Price
                             WHERE ItemNumber=@ItemNumber";

            SqlParameter[] parameters =
            {
                new SqlParameter("@ItemNumber", itemNumber),
                new SqlParameter("@ItemName", txtItemName.Text.Trim()),
                new SqlParameter("@ItemCategory", cmbCategory.Text),
                new SqlParameter("@Price", price)
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
            MessageBox.Show("Food item updated.");
            LoadFoodItems();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtItemNumber.Text, out int itemNumber))
            {
                MessageBox.Show("Please select a valid food item from the list.");
                return;
            }

                string query = "DELETE FROM FoodItem WHERE ItemNumber=@ItemNumber";
            SqlParameter[] parameters =
            {
                new SqlParameter("@ItemNumber", itemNumber)
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
            MessageBox.Show("Food item deleted.");
            LoadFoodItems();
        }

        private void dgvFoodItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvFoodItems.Rows[e.RowIndex];
                txtItemNumber.Text = row.Cells["ItemNumber"].Value.ToString();
                txtItemName.Text = row.Cells["ItemName"].Value.ToString();
                cmbCategory.Text = row.Cells["ItemCategory"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
            }
        }
    }
}
