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
using System.Data.SqlClient;

namespace Pharmacy
{
    public partial class StockDetails : Form
    {
        SqlCommand cmd1;
        public StockDetails()
        {
            InitializeComponent();
        }

        private void btnSDetailsExit_Click(object sender, EventArgs e)
        {
            AferLogin afl = new AferLogin();
            afl.Show();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSDetailsRefrash_Click(object sender, EventArgs e)
        {
            var connection = ConfigurationManager.ConnectionStrings["pharm1"];
            var con = new SqlConnection();
            con.ConnectionString = connection.ConnectionString;

            //Data Load at SalesDetails
            con.Open();
            cmd1 = new SqlCommand("select * from Stock_Details", con);
            DataTable dtcsd1 = new DataTable();
            SqlDataAdapter dasd = new SqlDataAdapter(cmd1);
            dasd.Fill(dtcsd1);
            dtgrdvwSDetails.DataSource = dtcsd1.DefaultView;
            con.Close();
        }
    }
}
