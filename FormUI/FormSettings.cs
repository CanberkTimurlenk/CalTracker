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

        private readonly IUserService _userService = new UserManager();
        private readonly IAimService _aimService = new AimManager();
        private readonly int _userId;
        public FormSettings(int userId)
        {
            _userId = userId;
            InitializeComponent();
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
            cmb_Aim.DataSource = _aimService.GetAll();
            cmb_Aim.DisplayMember = "Name";
            cmb_Aim.ValueMember = "Id";
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!txt_Firstname.Text.Trim().IsNullOrEmpty()) _userService.UpdateFirstnameByUserId(_userId, txt_Firstname.Text.Trim());
            if (!txt_Lastname.Text.Trim().IsNullOrEmpty()) _userService.UpdateLastnameByUserId(_userId, txt_Lastname.Text.Trim());
        }
        private void btn_aimSave_Click_1(object sender, EventArgs e)
        {
            if (cmb_Aim.SelectedIndex > -1) _userService.UpdateUserAimByUserId(_userId, (int)cmb_Aim.SelectedValue);

        }

        private void btn_HeightWeightSave_Click(object sender, EventArgs e)
        {
            if (nud_Height.Value > 0) _userService.UpdateAimByUserId(_userId, (double)nud_Height.Value);
            if (nud_Weight.Value > 0) _userService.UpdateWeightByUserId(_userId, (double)nud_Weight.Value);

        }
    }
}
