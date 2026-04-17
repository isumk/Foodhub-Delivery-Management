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
    public partial class FrmDependents : Form
    {
        public FrmDependents()
        {
            InitializeComponent();
        }

        private void FrmDependents_Load(object sender, EventArgs e)
        {
            LoadRiders();

            cmbRelationship.Items.Clear();
            cmbRelationship.Items.AddRange(new string[]
            {
                "Father", "Mother", "Son", "Daughter", "Wife", "Husband", "Brother", "Sister", "Other"
            });

            LoadDependents();
            ClearFields();
        }
        private void LoadRiders()
        {
            DataTable dt = DatabaseHelper.GetDataTable(
                "SELECT EmployeeNumber, FirstName + ' ' + LastName AS RiderName FROM Rider ORDER BY FirstName");

            cmbRider.DataSource = dt;
            cmbRider.DisplayMember = "RiderName";
            cmbRider.ValueMember = "EmployeeNumber";
        }

        private void LoadDependents()
        {
            string query = @"SELECT d.DependentID,
                                    d.EmployeeNumber,
                                    r.FirstName + ' ' + r.LastName AS RiderName,
                                    d.DependentName,
                                    d.RelationshipToRider,
                                    d.DateOfBirth
                             FROM Dependent d
                             INNER JOIN Rider r ON d.EmployeeNumber = r.EmployeeNumber
                             ORDER BY d.DependentID DESC";

            dgvDependents.DataSource = DatabaseHelper.GetDataTable(query);
        }

        private bool ValidateInputs()
        {
            if (cmbRider.SelectedValue == null)
            {
                MessageBox.Show("Please select a rider.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDependentName.Text) ||
                string.IsNullOrWhiteSpace(cmbRelationship.Text))
            {
                MessageBox.Show("Please fill all required fields.");
                return false;
            }

            if (dtpDependentDOB.Value.Date >= DateTime.Now.Date)
            {
                MessageBox.Show("Dependent date of birth must be in the past.");
                return false;
            }

            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            string query = @"INSERT INTO Dependent
                            (EmployeeNumber, DependentName, RelationshipToRider, DateOfBirth)
                            VALUES
                            (@EmployeeNumber, @DependentName, @RelationshipToRider, @DateOfBirth)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@EmployeeNumber", cmbRider.SelectedValue),
                new SqlParameter("@DependentName", txtDependentName.Text.Trim()),
                new SqlParameter("@RelationshipToRider", cmbRelationship.Text.Trim()),
                new SqlParameter("@DateOfBirth", dtpDependentDOB.Value.Date)
            };

            try
            {
                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Dependent saved successfully.");
                LoadDependents();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving dependent: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDependentID.Text))
            {
                MessageBox.Show("Please select a dependent first.");
                return;
            }

            if (!ValidateInputs()) return;

            string query = @"UPDATE Dependent SET
                            EmployeeNumber=@EmployeeNumber,
                            DependentName=@DependentName,
                            RelationshipToRider=@RelationshipToRider,
                            DateOfBirth=@DateOfBirth
                            WHERE DependentID=@DependentID";

            SqlParameter[] parameters =
            {
                new SqlParameter("@DependentID", int.Parse(txtDependentID.Text)),
                new SqlParameter("@EmployeeNumber", cmbRider.SelectedValue),
                new SqlParameter("@DependentName", txtDependentName.Text.Trim()),
                new SqlParameter("@RelationshipToRider", cmbRelationship.Text.Trim()),
                new SqlParameter("@DateOfBirth", dtpDependentDOB.Value.Date)
            };

            try
            {
                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Dependent updated successfully.");
                LoadDependents();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating dependent: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDependentID.Text))
            {
                MessageBox.Show("Please select a dependent first.");
                return;
            }

            if (MessageBox.Show("Delete this dependent?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            string query = "DELETE FROM Dependent WHERE DependentID=@DependentID";

            SqlParameter[] parameters =
            {
                new SqlParameter("@DependentID", int.Parse(txtDependentID.Text))
            };

            try
            {
                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Dependent deleted successfully.");
                LoadDependents();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting dependent: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtDependentID.Clear();
            txtDependentName.Clear();
            cmbRelationship.SelectedIndex = -1;
            dtpDependentDOB.Value = DateTime.Today;
        }

        private void cmbRider_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvDependents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvDependents.Rows[e.RowIndex];

            txtDependentID.Text = row.Cells["DependentID"].Value.ToString();
            cmbRider.SelectedValue = row.Cells["EmployeeNumber"].Value;
            txtDependentName.Text = row.Cells["DependentName"].Value.ToString();
            cmbRelationship.Text = row.Cells["RelationshipToRider"].Value.ToString();
            dtpDependentDOB.Value = Convert.ToDateTime(row.Cells["DateOfBirth"].Value);
        }
    }
}
