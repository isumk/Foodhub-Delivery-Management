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
            cmbShiftCode.Items.AddRange(new string[] { "Morning", "Evening", "Night" });
            LoadRiders();
            LoadBikes();
            LoadAssignments();
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
            dgvAssignments.DataSource = DatabaseHelper.GetDataTable("SELECT * FROM BikeAssignment ORDER BY AssignmentID DESC");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO BikeAssignment
                            (EmployeeNumber, VehicleRegNo, AssignmentDate, ShiftCode, MeterReadingAssigned, MeterReadingReturned)
                            VALUES
                            (@EmployeeNumber, @VehicleRegNo, @AssignmentDate, @ShiftCode, @MeterReadingAssigned, NULL)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@EmployeeNumber", cmbRider.SelectedValue),
                new SqlParameter("@VehicleRegNo", cmbBike.SelectedValue),
                new SqlParameter("@AssignmentDate", dtpAssignmentDate.Value.Date),
                new SqlParameter("@ShiftCode", cmbShiftCode.Text),
                new SqlParameter("@MeterReadingAssigned", decimal.Parse(txtMeterAssigned.Text))
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
            MessageBox.Show("Bike assigned successfully.");
            LoadAssignments();
        }

        private void btnReturnBike_Click(object sender, EventArgs e)
        {
            if (dgvAssignments.CurrentRow == null)
            {
                MessageBox.Show("Select an assignment first.");
                return;
            }

            int assignmentId = Convert.ToInt32(dgvAssignments.CurrentRow.Cells["AssignmentID"].Value);

            string query = @"UPDATE BikeAssignment
                             SET MeterReadingReturned=@MeterReadingReturned
                             WHERE AssignmentID=@AssignmentID";

            SqlParameter[] parameters =
            {
                new SqlParameter("@MeterReadingReturned", decimal.Parse(txtMeterReturned.Text)),
                new SqlParameter("@AssignmentID", assignmentId)
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
            MessageBox.Show("Bike return recorded.");
            LoadAssignments();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
