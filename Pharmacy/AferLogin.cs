using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;


namespace Pharmacy
{
    public partial class AferLogin : Form
    {
        public AferLogin()
        {
            InitializeComponent();
        }

        private void btnSalesDetails_Click(object sender, EventArgs e)
        {
            SalesDetails sd = new SalesDetails();
            sd.Show();
            this.Hide();
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            Accounts ac = new Accounts();
            ac.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult exit;

            exit = MessageBox.Show("Do you want to exit", "Pharmacy Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnStockDetails_Click(object sender, EventArgs e)
        {
            StockDetails sde = new StockDetails();
            sde.Show();
            this.Hide();
        }

        private void btnHRM_Click(object sender, EventArgs e)
        {
            HRM hr = new HRM();
            hr.Show();
            this.Hide();
        }
    }
}
