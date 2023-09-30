using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Legends;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class FormCompareMonthly : Form
    {
        public FormCompareMonthly()
        {
            InitializeComponent();
        }

        private void FormCompareMonthly_Load(object sender, EventArgs e)
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

            Random random = new Random();
            double[] ys1 = { 5, 18, 7, 12, 3 };
            double[] ys2 = { 3, 7, 20, 5, 9 };
            var user = new BarSeries()
            {
                Title = "Siz",
                StrokeColor = OxyColors.Black,
                FillColor = OxyColors.LightSeaGreen,
                StrokeThickness = 1,
            };
            var avarage = new BarSeries()
            {
                Title = "Diger Kullanicilar",
                StrokeColor = OxyColors.Black,
                FillColor = OxyColors.MediumOrchid,
                StrokeThickness = 1,
            };
            for (int i = 0; i < 5; i++)
            {
                user.Items.Add(new BarItem(ys1[i], i));
                avarage.Items.Add(new BarItem(ys2[i], i));
            }
            pv_Category.Model = new PlotModel 
            { 
                Title = "Kategori",
            };
            //pv_Category.Model.PlotType = PlotType.XY;
            var categoryAxis = new CategoryAxis { Position = AxisPosition.Bottom };
            categoryAxis.Labels.Add("Birinci");
            categoryAxis.Labels.Add("Ikinci");
            categoryAxis.Labels.Add("Ucuncu");
            categoryAxis.Labels.Add("Dorduncu");
            categoryAxis.Labels.Add("Besinci");
            var valueAxis = new LinearAxis { Position = AxisPosition.Left, MinimumPadding = 0, MaximumPadding = 0 };
            pv_Category.Model.Series.Add(user);
            pv_Category.Model.Series.Add(avarage);
            pv_Category.Model.Axes.Add(categoryAxis);
            pv_Category.Model.Axes.Add(valueAxis);
        }
    }
}
