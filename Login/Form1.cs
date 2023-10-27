using Microsoft.VisualBasic;

namespace Login
{
    public partial class Form1 : Form
    {
        RegistrationForm registrationform = new RegistrationForm();
        public Form1()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            registrationform.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            if (txtUsername.Text == "user" && txtPassword.Text == "pass")
            {
                main.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("Wrong Username and Password", "Incorrect input", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}