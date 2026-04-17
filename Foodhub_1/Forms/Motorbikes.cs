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
    public partial class FrmMotorBikes : Form
    {
        private readonly List<string> colours = new List<string>();

        public FrmMotorBikes()
        {
            InitializeComponent();
        }

        private void FrmMotorBikes_Load(object sender, EventArgs e)
        {
            LoadMotorBikes();
            ClearFields();
            
        }
        private void LoadMotorBikes()
        {
            dgvMotorBikes.DataSource = DatabaseHelper.GetDataTable("SELECT * FROM MotorBike ORDER BY VehicleRegNo");
        }
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtVehicleRegNo.Text) ||
                string.IsNullOrWhiteSpace(txtBrand.Text) ||
                string.IsNullOrWhiteSpace(txtModel.Text) ||
                string.IsNullOrWhiteSpace(txtEngineNumber.Text))
            {
                MessageBox.Show("Please fill all required fields.");
                return false;
            }

            if (lstColours.Items.Count == 0)
            {
                MessageBox.Show("Add at least one colour.");
                return false;
            }

            return true;
        }

        private void btnAddColour_Click(object sender, EventArgs e)
        {
            string colour = txtColour.Text.Trim();

            if (string.IsNullOrWhiteSpace(colour))
            {
                MessageBox.Show("Enter a colour first.");
                return;
            }

            if (!colours.Contains(colour))
            {
                colours.Add(colour);
                lstColours.Items.Add(colour);
            }

            txtColour.Clear();
            txtColour.Focus();
        }

        private void btnRemoveColour_Click(object sender, EventArgs e)
        {
            if (lstColours.SelectedItem == null) return;

            string colour = lstColours.SelectedItem.ToString();
            colours.Remove(colour);
            lstColours.Items.Remove(colour);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                con.Open();
                SqlTransaction trans = con.BeginTransaction();

                try
                {
                    string bikeQuery = @"INSERT INTO MotorBike
                                        (VehicleRegNo, Brand, Model, EngineNumber, VehicleRegisteredDate)
                                        VALUES
                                        (@VehicleRegNo, @Brand, @Model, @EngineNumber, @VehicleRegisteredDate)";

                    SqlCommand cmdBike = new SqlCommand(bikeQuery, con, trans);
                    cmdBike.Parameters.AddWithValue("@VehicleRegNo", txtVehicleRegNo.Text.Trim());
                    cmdBike.Parameters.AddWithValue("@Brand", txtBrand.Text.Trim());
                    cmdBike.Parameters.AddWithValue("@Model", txtModel.Text.Trim());
                    cmdBike.Parameters.AddWithValue("@EngineNumber", txtEngineNumber.Text.Trim());
                    cmdBike.Parameters.AddWithValue("@VehicleRegisteredDate", dtpVehicleRegisteredDate.Value.Date);
                    cmdBike.ExecuteNonQuery();

                    foreach (string colour in colours)
                    {
                        SqlCommand cmdColour = new SqlCommand(
                            "INSERT INTO BikeColour (VehicleRegNo, ColourName) VALUES (@VehicleRegNo, @ColourName)",
                            con, trans);

                        cmdColour.Parameters.AddWithValue("@VehicleRegNo", txtVehicleRegNo.Text.Trim());
                        cmdColour.Parameters.AddWithValue("@ColourName", colour);
                        cmdColour.ExecuteNonQuery();
                    }

                    trans.Commit();
                    MessageBox.Show("Motor bike saved successfully.");
                    LoadMotorBikes();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Error saving motor bike: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVehicleRegNo.Text))
            {
                MessageBox.Show("Select a motor bike first.");
                return;
            }

            if (!ValidateInputs()) return;

            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                con.Open();
                SqlTransaction trans = con.BeginTransaction();

                try
                {
                    string bikeQuery = @"UPDATE MotorBike SET
                                        Brand=@Brand,
                                        Model=@Model,
                                        EngineNumber=@EngineNumber,
                                        VehicleRegisteredDate=@VehicleRegisteredDate
                                        WHERE VehicleRegNo=@VehicleRegNo";

                    SqlCommand cmdBike = new SqlCommand(bikeQuery, con, trans);
                    cmdBike.Parameters.AddWithValue("@VehicleRegNo", txtVehicleRegNo.Text.Trim());
                    cmdBike.Parameters.AddWithValue("@Brand", txtBrand.Text.Trim());
                    cmdBike.Parameters.AddWithValue("@Model", txtModel.Text.Trim());
                    cmdBike.Parameters.AddWithValue("@EngineNumber", txtEngineNumber.Text.Trim());
                    cmdBike.Parameters.AddWithValue("@VehicleRegisteredDate", dtpVehicleRegisteredDate.Value.Date);
                    cmdBike.ExecuteNonQuery();

                    SqlCommand cmdDeleteColours = new SqlCommand(
                        "DELETE FROM BikeColour WHERE VehicleRegNo=@VehicleRegNo", con, trans);
                    cmdDeleteColours.Parameters.AddWithValue("@VehicleRegNo", txtVehicleRegNo.Text.Trim());
                    cmdDeleteColours.ExecuteNonQuery();

                    foreach (string colour in colours)
                    {
                        SqlCommand cmdColour = new SqlCommand(
                            "INSERT INTO BikeColour (VehicleRegNo, ColourName) VALUES (@VehicleRegNo, @ColourName)",
                            con, trans);

                        cmdColour.Parameters.AddWithValue("@VehicleRegNo", txtVehicleRegNo.Text.Trim());
                        cmdColour.Parameters.AddWithValue("@ColourName", colour);
                        cmdColour.ExecuteNonQuery();
                    }

                    trans.Commit();
                    MessageBox.Show("Motor bike updated successfully.");
                    LoadMotorBikes();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Error updating motor bike: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVehicleRegNo.Text))
            {
                MessageBox.Show("Select a motor bike first.");
                return;
            }

            if (MessageBox.Show("Delete this motor bike?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            string query = "DELETE FROM MotorBike WHERE VehicleRegNo=@VehicleRegNo";

            SqlParameter[] parameters =
            {
                new SqlParameter("@VehicleRegNo", txtVehicleRegNo.Text.Trim())
            };

            try
            {
                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Motor bike deleted successfully.");
                LoadMotorBikes();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting motor bike: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtVehicleRegNo.Clear();
            txtBrand.Clear();
            txtModel.Clear();
            txtEngineNumber.Clear();
            txtColour.Clear();
            dtpVehicleRegisteredDate.Value = DateTime.Today;
            colours.Clear();
            lstColours.Items.Clear();
        }

        private void dgvMotorBikes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvMotorBikes.Rows[e.RowIndex];

            txtVehicleRegNo.Text = row.Cells["VehicleRegNo"].Value.ToString();
            txtBrand.Text = row.Cells["Brand"].Value.ToString();
            txtModel.Text = row.Cells["Model"].Value.ToString();
            txtEngineNumber.Text = row.Cells["EngineNumber"].Value.ToString();
            dtpVehicleRegisteredDate.Value = Convert.ToDateTime(row.Cells["VehicleRegisteredDate"].Value);

            LoadColoursForBike(txtVehicleRegNo.Text.Trim());
        }

        private void LoadColoursForBike(string vehicleRegNo)
        {
            colours.Clear();
            lstColours.Items.Clear();

            string query = "SELECT ColourName FROM BikeColour WHERE VehicleRegNo=@VehicleRegNo ORDER BY ColourName";
            SqlParameter[] parameters =
            {
                new SqlParameter("@VehicleRegNo", vehicleRegNo)
            };

            DataTable dt = DatabaseHelper.GetDataTable(query, parameters);

            foreach (DataRow row in dt.Rows)
            {
                string colour = row["ColourName"].ToString();
                colours.Add(colour);
                lstColours.Items.Add(colour);
            }
        }
    }
}
