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
    public partial class SalesDetails : Form
    {
        SqlCommand cmd, cmdsd1, cmd3, cmd4;
        public SalesDetails()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSDExit_Click(object sender, EventArgs e)
        {
            DialogResult exit;

            exit = MessageBox.Show("Do you want to exit", "Pharmacy Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void SalesDetails_Load(object sender, EventArgs e)
        {
            var connection = ConfigurationManager.ConnectionStrings["pharm1"];
            var con = new SqlConnection();
            con.ConnectionString = connection.ConnectionString;

            //Data Load at SalesDetails
            con.Open();
            cmdsd1 = new SqlCommand("select * from Sales_Details", con);
            DataTable dtcsd1 = new DataTable();
            SqlDataAdapter dasd = new SqlDataAdapter(cmdsd1);
            dasd.Fill(dtcsd1);
            dtgrdvwSD.DataSource = dtcsd1.DefaultView;
            con.Close();


        }

        private void cmbSDCompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSDCompanyName.SelectedIndex==0)
            {
                cmbSDGroupName.Items.Clear();
                cmbSDGroupName.Items.Add("Omeprazol");
                cmbSDGroupName.Items.Add("paracetamol ");
                cmbSDGroupName.Items.Add("Acitamenophen");
            }
            else if (cmbSDCompanyName.SelectedIndex==1)
            {
                cmbSDGroupName.Items.Clear();
                cmbSDGroupName.Items.Add("Omeprazol");
                cmbSDGroupName.Items.Add("paracetamol");
            }
            else if (cmbSDCompanyName.SelectedIndex == 2)
            {
                cmbSDGroupName.Items.Clear();
                cmbSDGroupName.Items.Add("Omeprazol");
                cmbSDGroupName.Items.Add("paracetamol");
            }
            else
            {
                cmbSDGroupName.Items.Clear();
                cmbSDGroupName.Items.Add("Omeprazol");
                cmbSDGroupName.Items.Add("paracetamol");
            }
        }

        private void btnSDAdd_Click(object sender, EventArgs e)
        {
            if (cmbSDCompanyName.Text == "" && cmbSDGroupName.Text == "" && txtSDMedicineName.Text=="" && txtSDPrice.Text==""&& txtSDQty.Text=="")
            {
                MessageBox.Show("Please insert all the required data !!!!");
            }
            else
            {
                var connection = ConfigurationManager.ConnectionStrings["Pharm1"];
                var con = new SqlConnection();
                con.ConnectionString = connection.ConnectionString;

                con.Open();
                cmd = new SqlCommand("Insert into [dbo].[Sales_Details](Company_name ,Group_Name,Medicine_Name,Quantity,Price_per_box) values(@company_name,@group_Name,@medicine_Name,@quantity,@price_per_box)", con);
                cmd.Parameters.AddWithValue("@company_name", cmbSDCompanyName.Text);
                cmd.Parameters.AddWithValue("@group_Name", cmbSDGroupName.Text);
                cmd.Parameters.AddWithValue("@medicine_Name", txtSDMedicineName.Text );
                cmd.Parameters.AddWithValue("@quantity", txtSDQty.Text );
                cmd.Parameters.AddWithValue("@price_per_box", txtSDPrice.Text);
                cmd.ExecuteNonQuery();

                cmbSDCompanyName.Text = "";
                cmbSDGroupName.Text = "";
                txtSDMedicineId.Text = "";
                txtSDMedicineName.Text = "";
                txtSDQty.Text = "";
                txtSDPrice.Text = "";

                con.Close();

                //data load
                con.Open();
                cmd3 = new SqlCommand("select * from Sales_Details", con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd3);
                da.Fill(dt);
                dtgrdvwSD.DataSource = dt.DefaultView;
                con.Close();
            }
        }

        private void btnSDEdit_Click(object sender, EventArgs e)
        {
            if (cmbSDCompanyName.Text == "" && cmbSDGroupName.Text == "" && txtSDMedicineName.Text == "" && txtSDPrice.Text == "" && txtSDQty.Text == "")
            {
                MessageBox.Show("Please insert all the required data !!!!");
            }
            else
            {
                var connection = ConfigurationManager.ConnectionStrings["Pharm1"];
                var con = new SqlConnection();
                con.ConnectionString = connection.ConnectionString;

                con.Open();
                cmd3 = new SqlCommand("update Sales_Details set Company_name=@company_name,Group_Name=@group_Name, Quantity=@quantity, Price_per_box=@price_per_box, Medicine_Name=@medicine_Name where Medicine_Id=@medicine_Id", con);
                cmd3.Parameters.AddWithValue("@company_name", cmbSDCompanyName.Text);
                cmd3.Parameters.AddWithValue("@group_Name", cmbSDGroupName.Text);
                cmd3.Parameters.AddWithValue("@medicine_Name", txtSDMedicineName.Text);
                cmd3.Parameters.AddWithValue("@quantity", txtSDQty.Text);
                cmd3.Parameters.AddWithValue("@price_per_box", txtSDPrice.Text);
                cmd3.Parameters.AddWithValue("@medicine_Id", txtSDMedicineId.Text);
                cmd3.ExecuteNonQuery();

                cmbSDCompanyName.Text = "";
                cmbSDGroupName.Text = "";
                txtSDMedicineId.Text = "";
                txtSDMedicineName.Text = "";
                txtSDQty.Text = "";
                txtSDPrice.Text = "";
                txtSDMedicineId.Text = "";

                con.Close();

                //data load
                con.Open();
                cmd3 = new SqlCommand("select * from Sales_Details", con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd3);
                da.Fill(dt);
                dtgrdvwSD.DataSource = dt.DefaultView;
                con.Close();
            }
        }

        private void btnSDDelete_Click(object sender, EventArgs e)
        {
            if ( txtSDMedicineId.Text == "")
            {
                MessageBox.Show("Please insert all the required data !!!!");
            }
            else
            {
                var connection = ConfigurationManager.ConnectionStrings["Pharm1"];
                var con = new SqlConnection();
                con.ConnectionString = connection.ConnectionString;

                con.Open();
                cmd3 = new SqlCommand("delete from Sales_Details where Medicine_Id=@medicine_Id", con);
                cmd3.Parameters.AddWithValue("@medicine_Id", txtSDMedicineId.Text);
                cmd3.ExecuteNonQuery();
                con.Close();

                //data load
                con.Open();
                cmd3 = new SqlCommand("select * from Sales_Details", con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd3);
                da.Fill(dt);
                dtgrdvwSD.DataSource = dt.DefaultView;
                con.Close();
            }
        }

        private void btnSDSearch_Click(object sender, EventArgs e)
        {

            {
                if ( txtSDMedicineNameSearch.Text == "")
                {
                    MessageBox.Show("Please insert all the required data !!!!");
                }
                else
                {
                    var connection = ConfigurationManager.ConnectionStrings["Pharm1"];
                    var con = new SqlConnection();
                    con.ConnectionString = connection.ConnectionString;

                    con.Open();
                    cmd3 = new SqlCommand("Select * from Sales_Details where Company_name=@Company_name", con);
                    cmd3.Parameters.AddWithValue("@Company_name", txtSDMedicineNameSearch.Text);
                    cmd3.ExecuteNonQuery();
                    
                    con.Close();

                    //data load
                    con.Open();
                    cmd4 = new SqlCommand("Select * from Sales_Details where Company_name=@Company_name", con);
                    cmd4.Parameters.AddWithValue("@Company_name", txtSDMedicineNameSearch.Text);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd4);
                    da.Fill(dt);
                    dtgrdvwSD.DataSource = dt.DefaultView;
                    con.Close();
                }
            }
        }

        private void btnSDBack_Click(object sender, EventArgs e)
        {
            AferLogin af = new AferLogin();
            af.Show();
            this.Hide();
        }
    }
}
