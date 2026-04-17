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
    public partial class FrmDispatch : Form
    {
        public FrmDispatch()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void grpDispatch_Enter(object sender, EventArgs e)
        {

        }

        private void FrmDispatch_Load(object sender, EventArgs e)
        {
            LoadPendingOrders();
            LoadDispatchHistory();
        }
        private void LoadPendingOrders()
        {
            string query = @"SELECT OrderNo
                             FROM Orders
                             WHERE OrderStatus IN ('Pending','Preparing')
                             ORDER BY OrderNo DESC";

            DataTable dt = DatabaseHelper.GetDataTable(query);
            cmbOrdersPending.DataSource = dt;
            cmbOrdersPending.DisplayMember = "OrderNo";
            cmbOrdersPending.ValueMember = "OrderNo";
        }

        private void LoadDispatchHistory()
        {
            dgvDispatchHistory.DataSource = DatabaseHelper.GetDataTable(
                "SELECT OrderNo, CustomerID, OrderStatus, DispatchTime FROM Orders WHERE DispatchTime IS NOT NULL ORDER BY DispatchTime DESC");
        }
        private void btnDispatch_Click(object sender, EventArgs e)
        {
            string query = @"UPDATE Orders
                             SET OrderStatus='Dispatched',
                                 DispatchTime=@DispatchTime
                             WHERE OrderNo=@OrderNo";

            SqlParameter[] parameters =
            {
                new SqlParameter("@DispatchTime", dtpDispatchDateTime.Value),
                new SqlParameter("@OrderNo", cmbOrdersPending.SelectedValue)
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
            MessageBox.Show("Order dispatched.");
            LoadPendingOrders();
            LoadDispatchHistory();
        }

        private void dgvDispatchHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
