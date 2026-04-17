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
    public partial class FrmIngredients : Form
    {
        public FrmIngredients()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmIngredients_Load(object sender, EventArgs e)
        {
            LoadIngredients();
        }
        private void LoadIngredients()
        {
            dgvIngredients.DataSource = DatabaseHelper.GetDataTable("SELECT * FROM Ingredient ORDER BY IngredientID DESC");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Ingredient (IngredientName) VALUES (@IngredientName)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@IngredientName", txtIngredientName.Text.Trim())
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
            MessageBox.Show("Ingredient saved.");
            LoadIngredients();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Ingredient SET IngredientName=@IngredientName WHERE IngredientID=@IngredientID";
            SqlParameter[] parameters =
            {
                new SqlParameter("@IngredientID", int.Parse(txtIngredientID.Text)),
                new SqlParameter("@IngredientName", txtIngredientName.Text.Trim())
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
            MessageBox.Show("Ingredient updated.");
            LoadIngredients();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Ingredient WHERE IngredientID=@IngredientID";
            SqlParameter[] parameters =
            {
                new SqlParameter("@IngredientID", int.Parse(txtIngredientID.Text))
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
            MessageBox.Show("Ingredient deleted.");
            LoadIngredients();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void dgvIngredients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtIngredientID.Text = dgvIngredients.Rows[e.RowIndex].Cells["IngredientID"].Value.ToString();
                txtIngredientName.Text = dgvIngredients.Rows[e.RowIndex].Cells["IngredientName"].Value.ToString();
            }
        }
    }
}
