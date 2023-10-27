using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            txtPassword1.UseSystemPasswordChar = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword1.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword1.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string txtPass = txtPassword.Text;
            string txtPass1 = txtPassword1.Text;

            if (txtUsername.Text == "" || txtPassword.Text == "" || txtPassword1.Text == "")
            {
                MessageBox.Show("Please fill all blank spaces", "Incomplete!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPass == txtPass1 || txtPass1 == txtPass)
            {
                MessageBox.Show("You have been registered successfully.", "Registration Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Text = "";
                txtPassword1.Text = "";
                txtUsername.Text = "";
                checkBox1.Checked = false;
                  
            }
            else
            {
                MessageBox.Show("Password must be the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
