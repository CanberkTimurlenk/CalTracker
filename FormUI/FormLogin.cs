using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

            new FormRegister().Show();
            this.Hide();

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            /*
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            string login = ("SELECT * FROM csharp_user WHERE username =  '" + txtUsername.Text + "' and password = '" + txtPassword.Text + "' ");
            cmd = new NpgsqlCommand(login, conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            

            if (dr.Read() == true)
            {
                conn.Close();
                new Dashboard().Show();
                Dashboard.instance.lbl.Text = txtUsername.Text;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Credentials, please try Again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
                if (conn != null && conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            */
        }

        private void checkboxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';

            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
