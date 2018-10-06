using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void panel1_Paint(object sender, PaintEventArgs e)
        //{
        //    this.BackColor = Color.Blue;
        //    this.TransparencyKey = Color.Blue;
        //}

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "abc" && txtPassword.Text == "abc")
            {
                //Main mn = new Main();
                //mn.Show();
                AferLogin af = new AferLogin();
                af.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("please insert correct password and correct Id");

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtPassword.Clear();
            txtId.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult exit;

            exit = MessageBox.Show("Do you want to exit", "Pharmacy Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
