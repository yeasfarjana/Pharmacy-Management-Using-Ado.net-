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
    public partial class Accounts : Form
    {
        SqlCommand cmd5;
        public Accounts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AferLogin af = new AferLogin();
            af.Show();
            this.Hide();
        }

        private void btnAccountExit_Click(object sender, EventArgs e)
        {
            DialogResult exit;

            exit = MessageBox.Show("Do you want to exit", "Pharmacy Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Accounts_Load(object sender, EventArgs e)
        {
            var connection = ConfigurationManager.ConnectionStrings["pharm1"];
            var con = new SqlConnection();
            con.ConnectionString = connection.ConnectionString;

            //Data Load at SalesDetails
            con.Open();
            cmd5 = new SqlCommand("select * from vw_Accounts  ", con);
            DataTable dta = new DataTable();
            SqlDataAdapter daa = new SqlDataAdapter(cmd5);
            daa.Fill(dta);
            dtgrdvwAccounts.DataSource = dta.DefaultView;
            con.Close();

            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
        Bitmap bmp;
        private void btnAccountsPrint_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
            
        }
    }
}
