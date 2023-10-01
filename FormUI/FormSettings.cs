using Entities.Concrete;
using Microsoft.IdentityModel.Tokens;
using Services.Abstract;
using Services.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class FormSettings : Form
    {
        private readonly int _userId;
        private readonly IUserService _userService = new UserManager();
        private readonly IAimService _aimService = new AimManager();
        public FormSettings(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }
        private void FormSettings_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(32, 191, 107);
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(32, 191, 107),
                Color.FromArgb(50, 210, 255),
                360f
            );
            this.Paint += (sender, e) =>
            {
                e.Graphics.FillRectangle(linearGradientBrush, this.ClientRectangle);
            };
            var aims = _aimService.GetAll().Select(x => x.Name).ToList();
            cmb_Aim.DataSource = aims;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            //TODO: userId yi al
            if (!txt_Firstname.Text.Trim().IsNullOrEmpty()) _userService.ChangeUserFirstName(5, txt_Firstname.Text.Trim());
            if (!txt_Lastname.Text.Trim().IsNullOrEmpty()) _userService.ChangeUserLastName(5, txt_Lastname.Text.Trim());
        }
        private void btn_aimSave_Click_1(object sender, EventArgs e)
        {
            if (cmb_Aim.SelectedIndex > -1) _userService.ChangeUserAim(5, cmb_Aim.SelectedValue as Aim);

        }

        private void btn_HeightWeightSave_Click(object sender, EventArgs e)
        {
            if (nud_Height.Value > 0) _userService.ChangeUserHeight(5, (double)nud_Height.Value);
            if (nud_Weight.Value > 0) _userService.ChangeUserWeight(5, (double)nud_Weight.Value);

        }

        private void FormSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
