using Bunifu.UI.WinForms;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjectToG
{
    public partial class cylinder : Form
    {
        public cylinder()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            this.MouseDown += new MouseEventHandler(cylinder_MouseDown);
            this.tabPage1.MouseDown += new MouseEventHandler(cylinder_MouseDown);
            this.tabPage2.MouseDown += new MouseEventHandler(cylinder_MouseDown);
            this.tabPage3.MouseDown += new MouseEventHandler(cylinder_MouseDown);
            this.tabPage4.MouseDown += new MouseEventHandler(cylinder_MouseDown);
            this.tabPage5.MouseDown += new MouseEventHandler(cylinder_MouseDown);
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            switch (selectedIndex)
            {
                case 0:
                    trianglepages.SetPage(0);
                    break;
                case 1:
                    trianglepages.SetPage(1);
                    break;
                case 2:
                    trianglepages.SetPage(2);
                    break;
                case 3:
                    trianglepages.SetPage(3);
                    break;
                case 4:
                    trianglepages.SetPage(4);
                    break;
            }
        }

        private void skControl1_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs e)
        {
            var painter = new CSharpMath.SkiaSharp.MathPainter();
            painter.LaTeX = @"Formula: V = \pi r^{2}h";
            painter.TextColor = new SKColor(215, 241, 241);
            painter.WrapColor(100);
            painter.Draw(e.Surface.Canvas);
        }

        private void skControl2_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs e)
        {
            var painter = new CSharpMath.SkiaSharp.MathPainter();
            painter.LaTeX = @"Formula: V = \frac{\pi d^{2}h}{4}";
            painter.TextColor = new SKColor(215, 241, 241);
            painter.WrapColor(100);
            painter.Draw(e.Surface.Canvas);
        }

        private void skControl3_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs e)
        {
            var painter = new CSharpMath.SkiaSharp.MathPainter();
            painter.LaTeX = @"Formula: V = \frac{C^{2}h}{4\pi}";
            painter.TextColor = new SKColor(215, 241, 241);
            painter.WrapColor(100);
            painter.Draw(e.Surface.Canvas);
        }

        private void skControl4_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs e)
        {
            var painter = new CSharpMath.SkiaSharp.MathPainter();
            painter.LaTeX = @"Formula: S = \frac{\sqrt{3}}{4}a^{2}";
            painter.TextColor = new SKColor(215, 241, 241);
            painter.WrapColor(100);
            painter.Draw(e.Surface.Canvas);
        }

        private void skControl5_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs e)
        {
            var painter = new CSharpMath.SkiaSharp.MathPainter();
            painter.LaTeX = @"Formula: S=\frac{b}{2}\sqrt{a^{2}-\frac{b^{2}}{4}}";
            painter.TextColor = new SKColor(215, 241, 241);
            painter.WrapColor(100);
            painter.Draw(e.Surface.Canvas);

        }
        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CalculateVolumeUsingRadiusAndHeight()
        {
            string radiusInput = bunifuTextBox1.Text;
            string heightInput = bunifuTextBox2.Text;

            if (string.IsNullOrWhiteSpace(radiusInput) || string.IsNullOrWhiteSpace(heightInput))
            {
                MessageBox.Show("Radius and height must be filled out.");
                return;
            }

            if (!double.TryParse(radiusInput, out double radius) || radius <= 0)
            {
                MessageBox.Show("Radius must be a positive number.");
                return;
            }

            if (!double.TryParse(heightInput, out double height) || height <= 0)
            {
                MessageBox.Show("Height must be a positive number.");
                return;
            }

            double volume = Math.PI * Math.Pow(radius, 2) * height;
            bunifuTextBox3.Text = volume.ToString();
        }
        private void CalculateVolumeUsingCircumferenceAndHeight()
        {
            string circumferenceInput = bunifuTextBox10.Text;
            string heightInput = bunifuTextBox9.Text;

            if (string.IsNullOrWhiteSpace(circumferenceInput) || string.IsNullOrWhiteSpace(heightInput))
            {
                MessageBox.Show("Circumference and height must be filled out.");
                return;
            }

            if (!double.TryParse(circumferenceInput, out double circumference) || circumference <= 0)
            {
                MessageBox.Show("Circumference must be a positive number.");
                return;
            }

            if (!double.TryParse(heightInput, out double height) || height <= 0)
            {
                MessageBox.Show("Height must be a positive number.");
                return;
            }

            double radius = circumference / (2 * Math.PI);
            double volume = Math.PI * Math.Pow(radius, 2) * height;
            bunifuTextBox11.Text = volume.ToString();
        }


        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                CalculateVolumeUsingRadiusAndHeight();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                CalculateVolumeUsingDiameterAndHeight();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                CalculateVolumeUsingCircumferenceAndHeight();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                
            }
            else
            {
                
            }
        }
        private void CalculateVolumeUsingDiameterAndHeight()
        {
            string diameterInput = bunifuTextBox6.Text;
            string heightInput = bunifuTextBox5.Text;

            if (string.IsNullOrWhiteSpace(diameterInput) || string.IsNullOrWhiteSpace(heightInput))
            {
                MessageBox.Show("Diameter and height must be filled out.");
                return;
            }

            if (!double.TryParse(diameterInput, out double diameter) || diameter <= 0)
            {
                MessageBox.Show("Diameter must be a positive number.");
                return;
            }

            if (!double.TryParse(heightInput, out double height) || height <= 0)
            {
                MessageBox.Show("Height must be a positive number.");
                return;
            }

            double radius = diameter / 2;
            double volume = Math.PI * Math.Pow(radius, 2) * height;
            bunifuTextBox7.Text = volume.ToString();
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cylinder_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}



