using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Foodhub_1
{
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtNIC_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            string query = "SELECT * FROM Customer ORDER BY CustomerID DESC";
            dgvCustomers.DataSource = DatabaseHelper.GetDataTable(query);
        }

        private bool ValidateCustomerInputs()
        {
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text) ||
                string.IsNullOrWhiteSpace(txtNIC.Text) ||
                string.IsNullOrWhiteSpace(txtContact.Text) ||
                string.IsNullOrWhiteSpace(txtLocationNo.Text) ||
                string.IsNullOrWhiteSpace(txtLane.Text) ||
                string.IsNullOrWhiteSpace(txtStreet.Text) ||
                string.IsNullOrWhiteSpace(txtCity.Text))
            {
                MessageBox.Show("Please fill all required fields.");
                return false;
            }

            if (dtpDOB.Value.Date >= DateTime.Now.Date)
            {
                MessageBox.Show("Date of birth must be in the past.");
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateCustomerInputs()) return;

            string query = @"INSERT INTO Customer
                            (CustomerName, NIC, DateOfBirth, ContactNumber, LocationNo, Lane, Street, City)
                            VALUES
                            (@CustomerName, @NIC, @DateOfBirth, @ContactNumber, @LocationNo, @Lane, @Street, @City)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@CustomerName", txtCustomerName.Text.Trim()),
                new SqlParameter("@NIC", txtNIC.Text.Trim()),
                new SqlParameter("@DateOfBirth", dtpDOB.Value.Date),
                new SqlParameter("@ContactNumber", txtContact.Text.Trim()),
                new SqlParameter("@LocationNo", txtLocationNo.Text.Trim()),
                new SqlParameter("@Lane", txtLane.Text.Trim()),
                new SqlParameter("@Street", txtStreet.Text.Trim()),
                new SqlParameter("@City", txtCity.Text.Trim())
            };

            try
            {
                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Customer saved successfully.");
                LoadCustomers();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerID.Text))
            {
                MessageBox.Show("Please select a customer first.");
                return;
            }

            if (!ValidateCustomerInputs()) return;

            string query = @"UPDATE Customer SET
                            CustomerName=@CustomerName,
                            NIC=@NIC,
                            DateOfBirth=@DateOfBirth,
                            ContactNumber=@ContactNumber,
                            LocationNo=@LocationNo,
                            Lane=@Lane,
                            Street=@Street,
                            City=@City
                            WHERE CustomerID=@CustomerID";

            SqlParameter[] parameters =
            {
                new SqlParameter("@CustomerID", int.Parse(txtCustomerID.Text)),
                new SqlParameter("@CustomerName", txtCustomerName.Text.Trim()),
                new SqlParameter("@NIC", txtNIC.Text.Trim()),
                new SqlParameter("@DateOfBirth", dtpDOB.Value.Date),
                new SqlParameter("@ContactNumber", txtContact.Text.Trim()),
                new SqlParameter("@LocationNo", txtLocationNo.Text.Trim()),
                new SqlParameter("@Lane", txtLane.Text.Trim()),
                new SqlParameter("@Street", txtStreet.Text.Trim()),
                new SqlParameter("@City", txtCity.Text.Trim())
            };

            try
            {
                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Customer updated successfully.");
                LoadCustomers();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            txtCustomerID.Clear();
            txtCustomerName.Clear();
            txtNIC.Clear();
            txtContact.Clear();
            txtLocationNo.Clear();
            txtLane.Clear();
            txtStreet.Clear();
            txtCity.Clear();
            dtpDOB.Value = DateTime.Now.Date;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerID.Text))
            {
                MessageBox.Show("Please select a customer first.");
                return;
            }

            DialogResult result = MessageBox.Show("Delete this customer?", "Confirm", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;

            string query = "DELETE FROM Customer WHERE CustomerID=@CustomerID";
            SqlParameter[] parameters =
            {
                new SqlParameter("@CustomerID", int.Parse(txtCustomerID.Text))
            };

            try
            {
                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Customer deleted successfully.");
                LoadCustomers();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = @"SELECT * FROM Customer
                             WHERE CustomerName LIKE @Search
                             OR NIC LIKE @Search
                             OR ContactNumber LIKE @Search";

            SqlParameter[] parameters =
            {
                new SqlParameter("@Search", "%" + txtSearch.Text.Trim() + "%")
            };

            dgvCustomers.DataSource = DatabaseHelper.GetDataTable(query, parameters);
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomers.Rows[e.RowIndex];

                txtCustomerID.Text = row.Cells["CustomerID"].Value.ToString();
                txtCustomerName.Text = row.Cells["CustomerName"].Value.ToString();
                txtNIC.Text = row.Cells["NIC"].Value.ToString();
                dtpDOB.Value = Convert.ToDateTime(row.Cells["DateOfBirth"].Value);
                txtContact.Text = row.Cells["ContactNumber"].Value.ToString();
                txtLocationNo.Text = row.Cells["LocationNo"].Value.ToString();
                txtLane.Text = row.Cells["Lane"].Value.ToString();
                txtStreet.Text = row.Cells["Street"].Value.ToString();
                txtCity.Text = row.Cells["City"].Value.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
