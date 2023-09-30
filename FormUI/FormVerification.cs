using Services;
using Services.Concrete;

namespace FormUI
{
    public partial class FormVerification : Form
    {
        private readonly IAuthService _authService = new AuthManager();
        private readonly int _userId;
        public FormVerification(int userId)
        {
            _userId = userId;
            InitializeComponent();
        }

        private void btn_Verify_Click(object sender, EventArgs e)
        {
            try
            {
                _authService.Verify(_userId, txt_Verification.Text);
                MessageBox.Show("Verification successful");
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Verification code was wrong");
            }

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
