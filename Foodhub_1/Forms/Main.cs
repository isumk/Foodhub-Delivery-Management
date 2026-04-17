using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodhub_1
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            new FrmCustomers().ShowDialog();
        }

        private void btnFoodItems_Click(object sender, EventArgs e)
        {
            new FrmFoodItems().ShowDialog();
        }

        private void btnIngredients_Click(object sender, EventArgs e)
        {
            new FrmIngredients().ShowDialog();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            new FrmOrders().ShowDialog();
        }

        private void btnDispatchOrders_Click(object sender, EventArgs e)
        {
            new FrmDispatch().ShowDialog();
        }

        private void btnRiders_Click(object sender, EventArgs e)
        {
            new FrmRiders().ShowDialog();
        }

        private void btnDependents_Click(object sender, EventArgs e)
        {
            new FrmDependents().ShowDialog();
        }

        private void btnMotorBikes_Click(object sender, EventArgs e)
        {
            new FrmMotorBikes().ShowDialog();
        }

        private void btnBikeAssignments_Click(object sender, EventArgs e)
        {
           new FrmBikeassignments().ShowDialog();
        }
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
