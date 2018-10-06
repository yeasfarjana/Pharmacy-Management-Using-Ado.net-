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
    public partial class HRM : Form
    {
        SqlCommand cmd1,cmd3;
        public HRM()
        {
            InitializeComponent();
        }

        private void btnHRMexit_Click(object sender, EventArgs e)
        {
            DialogResult exit;

            exit = MessageBox.Show("Do you want to exit", "Pharmacy Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnHRMback_Click(object sender, EventArgs e)
        {
            AferLogin af = new AferLogin();
            af.Show();
            this.Hide();
        }

        private void btnHRMadd_Click(object sender, EventArgs e)
        {
            if (cmbHRMStatus.Text==""&&txtHRMemployeeName.Text==""&&txtHRMAddress.Text==""&&txtHRMContactNumber.Text==""&&txtHRMSalary.Text=="")
            {
                MessageBox.Show("Please insert all the required data !!!!");
            }
            else
            {
                var connection = ConfigurationManager.ConnectionStrings["Pharm1"];
                var con = new SqlConnection();
                con.ConnectionString = connection.ConnectionString;

                con.Open();
                cmd1 = new SqlCommand("Insert into [dbo].[Human_Resource_Management](Status,Employee_Name ,Address,Contact_Number,Salary) values(@Status,@Employee_Name,@Address,@Contact_Number,@Salary)", con);
                cmd1.Parameters.AddWithValue("@Status", cmbHRMStatus.Text );
                cmd1.Parameters.AddWithValue("@Employee_Name", txtHRMemployeeName.Text );
                cmd1.Parameters.AddWithValue("@Address", txtHRMAddress.Text );
                cmd1.Parameters.AddWithValue("@Contact_Number", txtHRMContactNumber.Text );
                cmd1.Parameters.AddWithValue("@Salary", txtHRMSalary.Text );
                cmd1.ExecuteNonQuery();
                con.Close();

                //data load
                con.Open();
                cmd3 = new SqlCommand("select * from Human_Resource_Management", con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd3);
                da.Fill(dt);
                dtgrdvwHRM.DataSource = dt.DefaultView;
                con.Close();
            }
        }

        private void btnHRMEdit_Click(object sender, EventArgs e)
        {
            if (cmbHRMStatus.Text == "" && txtHRMemployeeName.Text == "" && txtHRMAddress.Text == "" && txtHRMContactNumber.Text == "" && txtHRMSalary.Text == "")
            {
                MessageBox.Show("Please insert all the required data !!!!");
            }
            else
            {
                var connection = ConfigurationManager.ConnectionStrings["Pharm1"];
                var con = new SqlConnection();
                con.ConnectionString = connection.ConnectionString;

                con.Open();
                cmd1 = new SqlCommand("Update [dbo].[Human_Resource_Management] set Status=@Status,Employee_Name=@Employee_Name ,Address=@Address,Salary=@Salary where Contact_Number=@Contact_Number", con);
                cmd1.Parameters.AddWithValue("@Status", cmbHRMStatus.Text);
                cmd1.Parameters.AddWithValue("@Employee_Name", txtHRMemployeeName.Text);
                cmd1.Parameters.AddWithValue("@Address", txtHRMAddress.Text);
                cmd1.Parameters.AddWithValue("@Contact_Number", txtHRMContactNumber.Text);
                //cmd1.Parameters.AddWithValue("@Contact_Number", txtforEditDelete.Text );
                cmd1.Parameters.AddWithValue("@Salary", txtHRMSalary.Text);
                cmd1.ExecuteNonQuery();
                con.Close();

                //data load
                con.Open();
                cmd3 = new SqlCommand("select * from Human_Resource_Management", con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd3);
                da.Fill(dt);
                dtgrdvwHRM.DataSource = dt.DefaultView;
                con.Close();
            }
        }

        private void HRM_Load(object sender, EventArgs e)
        {

            var connection = ConfigurationManager.ConnectionStrings["Pharm1"];
            var con = new SqlConnection();
            con.ConnectionString = connection.ConnectionString;

            con.Open();
            cmd3 = new SqlCommand("select * from Human_Resource_Management", con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd3);
            da.Fill(dt);
            dtgrdvwHRM.DataSource = dt.DefaultView;
            con.Close();
        }

        private void btnHRMdelete_Click(object sender, EventArgs e)
        {
            if ( txtHRMemployeeName.Text == "")
            {
                MessageBox.Show("Please insert all the required data !!!!");
            }
            else
            {
                var connection = ConfigurationManager.ConnectionStrings["Pharm1"];
                var con = new SqlConnection();
                con.ConnectionString = connection.ConnectionString;

                con.Open();
                cmd1 = new SqlCommand("delete from [dbo].[Human_Resource_Management] where Employee_Name=@Employee_Name", con);

                cmd1.Parameters.AddWithValue("@Employee_Name",txtHRMemployeeName.Text );
                
                cmd1.ExecuteNonQuery();
                con.Close();

                //data load
                con.Open();
                cmd3 = new SqlCommand("select * from Human_Resource_Management", con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd3);
                da.Fill(dt);
                dtgrdvwHRM.DataSource = dt.DefaultView;
                con.Close();
            }
        }
    }
}
