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
    public partial class FrmRiders : Form
    {
        public FrmRiders()
        {
            InitializeComponent();
        }

        private void Riders_Load(object sender, EventArgs e)
        {
            LoadRiders();
        }
        private void LoadRiders()
        {
            dgvRiders.DataSource = DatabaseHelper.GetDataTable("SELECT * FROM Rider ORDER BY EmployeeNumber DESC");
        }
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtNIC.Text) ||
                string.IsNullOrWhiteSpace(txtContact.Text) ||
                string.IsNullOrWhiteSpace(txtLicenseNumber.Text) ||
                string.IsNullOrWhiteSpace(txtLocationNo.Text) ||
                string.IsNullOrWhiteSpace(txtLane.Text) ||
                string.IsNullOrWhiteSpace(txtStreet.Text) ||
                string.IsNullOrWhiteSpace(txtCity.Text))
            {
                MessageBox.Show("Please fill all required fields.");
                return false;
            }

            if (dtpDOB.Value.Date >= DateTime.Today)
            {
                MessageBox.Show("Date of birth must be in the past.");
                return false;
            }

            return true;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO Rider
                            (FirstName, MiddleName, LastName, NIC, DateOfBirth, ContactNumber, LicenseNumber, LocationNo, Lane, Street, City)
                            VALUES
                            (@FirstName, @MiddleName, @LastName, @NIC, @DateOfBirth, @ContactNumber, @LicenseNumber, @LocationNo, @Lane, @Street, @City)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@FirstName", txtFirstName.Text.Trim()),
                new SqlParameter("@MiddleName", txtMiddleName.Text.Trim()),
                new SqlParameter("@LastName", txtLastName.Text.Trim()),
                new SqlParameter("@NIC", txtNIC.Text.Trim()),
                new SqlParameter("@DateOfBirth", dtpDOB.Value.Date),
                new SqlParameter("@ContactNumber", txtContact.Text.Trim()),
                new SqlParameter("@LicenseNumber", txtLicenseNumber.Text.Trim()),
                new SqlParameter("@LocationNo", txtLocationNo.Text.Trim()),
                new SqlParameter("@Lane", txtLane.Text.Trim()),
                new SqlParameter("@Street", txtStreet.Text.Trim()),
                new SqlParameter("@City", txtCity.Text.Trim())
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
            MessageBox.Show("Rider saved.");
            LoadRiders();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmployeeNumber.Text))
            {
                MessageBox.Show("Select a rider first.");
                return;
            }

            if (!ValidateInputs()) return;

            string query = @"UPDATE Rider SET
                            FirstName=@FirstName,
                            MiddleName=@MiddleName,
                            LastName=@LastName,
                            NIC=@NIC,
                            DateOfBirth=@DateOfBirth,
                            ContactNumber=@ContactNumber,
                            LicenseNumber=@LicenseNumber,
                            LocationNo=@LocationNo,
                            Lane=@Lane,
                            Street=@Street,
                            City=@City
                            WHERE EmployeeNumber=@EmployeeNumber";

            SqlParameter[] parameters =
            {
                new SqlParameter("@EmployeeNumber", int.Parse(txtEmployeeNumber.Text)),
                new SqlParameter("@FirstName", txtFirstName.Text.Trim()),
                new SqlParameter("@MiddleName", txtMiddleName.Text.Trim()),
                new SqlParameter("@LastName", txtLastName.Text.Trim()),
                new SqlParameter("@NIC", txtNIC.Text.Trim()),
                new SqlParameter("@DateOfBirth", dtpDOB.Value.Date),
                new SqlParameter("@ContactNumber", txtContact.Text.Trim()),
                new SqlParameter("@LicenseNumber", txtLicenseNumber.Text.Trim()),
                new SqlParameter("@LocationNo", txtLocationNo.Text.Trim()),
                new SqlParameter("@Lane", txtLane.Text.Trim()),
                new SqlParameter("@Street", txtStreet.Text.Trim()),
                new SqlParameter("@City", txtCity.Text.Trim())
            };

            try
            {
                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Rider updated.");
                LoadRiders();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating rider: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmployeeNumber.Text))
            {
                MessageBox.Show("Please select a rider first.");
                return;
            }

            if (MessageBox.Show("Delete this rider?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            string query = "DELETE FROM Rider WHERE EmployeeNumber=@EmployeeNumber";

            SqlParameter[] parameters =
            {
                new SqlParameter("@EmployeeNumber", int.Parse(txtEmployeeNumber.Text))
            };

            try
            {
                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Rider deleted successfully.");
                LoadRiders();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting rider: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtEmployeeNumber.Clear();
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtLastName.Clear();
            txtNIC.Clear();
            txtContact.Clear();
            txtLicenseNumber.Clear();
            txtLocationNo.Clear();
            txtLane.Clear();
            txtStreet.Clear();
            txtCity.Clear();
            dtpDOB.Value = DateTime.Today;
        }

        private void dgvRiders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
