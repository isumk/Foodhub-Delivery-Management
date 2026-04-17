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
    public partial class FrmBikeassignments : Form
    {
        public FrmBikeassignments()
        {
            InitializeComponent();
        }

        private void FrmBikeassignments_Load(object sender, EventArgs e)
        {
            cmbShiftCode.Items.Clear();
            cmbShiftCode.Items.AddRange(new string[] { "Morning", "Evening", "Night" });

            LoadRiders();
            LoadBikes();
            LoadAssignments();
            ClearFields();
        }
        private void LoadRiders()
        {
            DataTable dt = DatabaseHelper.GetDataTable("SELECT EmployeeNumber, FirstName + ' ' + LastName AS RiderName FROM Rider");
            cmbRider.DataSource = dt;
            cmbRider.DisplayMember = "RiderName";
            cmbRider.ValueMember = "EmployeeNumber";
        }

        private void LoadBikes()
        {
            DataTable dt = DatabaseHelper.GetDataTable("SELECT VehicleRegNo FROM MotorBike");
            cmbBike.DataSource = dt;
            cmbBike.DisplayMember = "VehicleRegNo";
            cmbBike.ValueMember = "VehicleRegNo";
        }

        private void LoadAssignments()
        {
            string query = @"SELECT ba.AssignmentID,
                                    ba.EmployeeNumber,
                                    r.FirstName + ' ' + r.LastName AS RiderName,
                                    ba.VehicleRegNo,
                                    ba.AssignmentDate,
                                    ba.ShiftCode,
                                    ba.MeterReadingAssigned,
                                    ba.MeterReadingReturned
                             FROM BikeAssignment ba
                             INNER JOIN Rider r ON ba.EmployeeNumber = r.EmployeeNumber
                             ORDER BY ba.AssignmentID DESC";

            dgvAssignments.DataSource = DatabaseHelper.GetDataTable(query);
        }
        private bool ValidateAssignInputs()
        {
            if (cmbRider.SelectedValue == null || cmbBike.SelectedValue == null)
            {
                MessageBox.Show("Please select rider and bike.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbShiftCode.Text))
            {
                MessageBox.Show("Please select a shift.");
                return false;
            }

            decimal meterAssigned;
            if (!decimal.TryParse(txtMeterAssigned.Text, out meterAssigned) || meterAssigned < 0)
            {
                MessageBox.Show("Enter a valid assigned meter reading.");
                return false;
            }

            return true;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateAssignInputs()) return;

            string query = @"INSERT INTO BikeAssignment
                            (EmployeeNumber, VehicleRegNo, AssignmentDate, ShiftCode, MeterReadingAssigned, MeterReadingReturned)
                            VALUES
                            (@EmployeeNumber, @VehicleRegNo, @AssignmentDate, @ShiftCode, @MeterReadingAssigned, NULL)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@EmployeeNumber", cmbRider.SelectedValue),
                new SqlParameter("@VehicleRegNo", cmbBike.SelectedValue),
                new SqlParameter("@AssignmentDate", dtpAssignmentDate.Value.Date),
                new SqlParameter("@ShiftCode", cmbShiftCode.Text.Trim()),
                new SqlParameter("@MeterReadingAssigned", decimal.Parse(txtMeterAssigned.Text))
            };

            try
            {
                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Bike assigned successfully.");
                LoadAssignments();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving bike assignment: " + ex.Message);
            }
        }

        private void btnReturnBike_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAssignmentID.Text))
            {
                MessageBox.Show("Please select an assignment first.");
                return;
            }

            decimal meterReturned;
            if (!decimal.TryParse(txtMeterReturned.Text, out meterReturned) || meterReturned < 0)
            {
                MessageBox.Show("Enter a valid returned meter reading.");
                return;
            }

            string query = @"UPDATE BikeAssignment
                             SET MeterReadingReturned=@MeterReadingReturned
                             WHERE AssignmentID=@AssignmentID";

            SqlParameter[] parameters =
            {
                new SqlParameter("@MeterReadingReturned", meterReturned),
                new SqlParameter("@AssignmentID", int.Parse(txtAssignmentID.Text))
            };

            try
            {
                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Bike return recorded successfully.");
                LoadAssignments();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error recording return meter: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAssignmentID.Text))
            {
                MessageBox.Show("Please select an assignment first.");
                return;
            }

            if (!ValidateAssignInputs()) return;

            decimal? meterReturned = null;
            if (!string.IsNullOrWhiteSpace(txtMeterReturned.Text))
            {
                decimal val;
                if (!decimal.TryParse(txtMeterReturned.Text, out val))
                {
                    MessageBox.Show("Returned meter is invalid.");
                    return;
                }
                meterReturned = val;
            }

            string query = @"UPDATE BikeAssignment SET
                            EmployeeNumber=@EmployeeNumber,
                            VehicleRegNo=@VehicleRegNo,
                            AssignmentDate=@AssignmentDate,
                            ShiftCode=@ShiftCode,
                            MeterReadingAssigned=@MeterReadingAssigned,
                            MeterReadingReturned=@MeterReadingReturned
                            WHERE AssignmentID=@AssignmentID";

            SqlParameter[] parameters =
            {
                new SqlParameter("@AssignmentID", int.Parse(txtAssignmentID.Text)),
                new SqlParameter("@EmployeeNumber", cmbRider.SelectedValue),
                new SqlParameter("@VehicleRegNo", cmbBike.SelectedValue),
                new SqlParameter("@AssignmentDate", dtpAssignmentDate.Value.Date),
                new SqlParameter("@ShiftCode", cmbShiftCode.Text.Trim()),
                new SqlParameter("@MeterReadingAssigned", decimal.Parse(txtMeterAssigned.Text)),
                new SqlParameter("@MeterReadingReturned", (object)meterReturned ?? DBNull.Value)
            };

            try
            {
                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Bike assignment updated successfully.");
                LoadAssignments();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating bike assignment: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAssignmentID.Text))
            {
                MessageBox.Show("Please select an assignment first.");
                return;
            }

            if (MessageBox.Show("Delete this bike assignment?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            string query = "DELETE FROM BikeAssignment WHERE AssignmentID=@AssignmentID";

            SqlParameter[] parameters =
            {
                new SqlParameter("@AssignmentID", int.Parse(txtAssignmentID.Text))
            };

            try
            {
                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Bike assignment deleted successfully.");
                LoadAssignments();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting bike assignment: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtAssignmentID.Clear();
            txtMeterAssigned.Clear();
            txtMeterReturned.Clear();
            cmbShiftCode.SelectedIndex = -1;
            dtpAssignmentDate.Value = DateTime.Today;
        }

        private void dgvAssignments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvAssignments.Rows[e.RowIndex];

            txtAssignmentID.Text = row.Cells["AssignmentID"].Value.ToString();
            cmbRider.SelectedValue = row.Cells["EmployeeNumber"].Value;
            cmbBike.SelectedValue = row.Cells["VehicleRegNo"].Value.ToString();
            dtpAssignmentDate.Value = Convert.ToDateTime(row.Cells["AssignmentDate"].Value);
            cmbShiftCode.Text = row.Cells["ShiftCode"].Value.ToString();
            txtMeterAssigned.Text = row.Cells["MeterReadingAssigned"].Value.ToString();
            txtMeterReturned.Text = row.Cells["MeterReadingReturned"].Value == DBNull.Value
                ? ""
                : row.Cells["MeterReadingReturned"].Value.ToString();
        }
    }
}
