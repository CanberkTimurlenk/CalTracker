using Entities.Concrete;
using Entities.Exceptions;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class FormLogin : Form
    {
        private readonly IAuthService _authService = new AuthManager();
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
            txt_Username.Text = "";
            txt_Password.Text = "";
            txt_Username.Focus();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var userToLogin = new Entities.Dtos.UserForLoginDto
            {
                Email = txt_Username.Text,
                Password = txt_Password.Text
            };


            try
            {
                _authService.Login(userToLogin);
                MessageBox.Show("Logged in Successfuly!");
            }
            catch (WrongCredentialsException)
            {
                MessageBox.Show("Wrong email or password.");
            }

            catch (UserNotVerifiedException ex)
            {
                MessageBox.Show("Please complete the verification process");

                var formVerification = new FormVerification(ex.UserId);
                formVerification.Show();
                this.Hide();
            }

        }

        private void checkboxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chckbox_ShowPassword.Checked)
            {
                txt_Password.PasswordChar = '\0';
            }
            else
            {
                txt_Password.PasswordChar = '*';

            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_CloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
