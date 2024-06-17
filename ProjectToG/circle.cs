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
    public partial class circle : Form
    {
        public circle()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            this.MouseDown += new MouseEventHandler(circle_MouseDown);
            this.tabPage1.MouseDown += new MouseEventHandler(circle_MouseDown);
            this.tabPage2.MouseDown += new MouseEventHandler(circle_MouseDown);
            this.tabPage3.MouseDown += new MouseEventHandler(circle_MouseDown);
            this.tabPage4.MouseDown += new MouseEventHandler(circle_MouseDown);
            this.tabPage5.MouseDown += new MouseEventHandler(circle_MouseDown);
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
            painter.LaTeX = @"Formula: S=\pi r^{2}";
            painter.TextColor = new SKColor(215, 241, 241);
            painter.WrapColor(100);
            painter.Draw(e.Surface.Canvas);
        }

        private void skControl2_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs e)
        {
            var painter = new CSharpMath.SkiaSharp.MathPainter();
            painter.LaTeX = @"Formula: S=\frac{\pi d^{2}}{4}";
            painter.TextColor = new SKColor(215, 241, 241);
            painter.WrapColor(100);
            painter.Draw(e.Surface.Canvas);
        }

        private void skControl3_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs e)
        {
            var painter = new CSharpMath.SkiaSharp.MathPainter();
            painter.LaTeX = @"Formula: S=\frac{C^{2}}{4\pi}";
            painter.TextColor = new SKColor(215, 241, 241);
            painter.WrapColor(100);
            painter.Draw(e.Surface.Canvas);
        }

        private void skControl4_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs e)
        {
            var painter = new CSharpMath.SkiaSharp.MathPainter();
            painter.LaTeX = @"Formula: S=\frac{1}{2}r^{2}\theta";
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

        private void CalculateCircleAreaWithRadius()
        {
            string radiusInput = bunifuTextBox1.Text;

            if (string.IsNullOrWhiteSpace(radiusInput))
            {
                MessageBox.Show("Radius must be filled out.");
                return;
            }

            if (!double.TryParse(radiusInput, out double radius) || radius <= 0)
            {
                MessageBox.Show("Radius must be a positive number.");
                return;
            }

            double area = Math.PI * Math.Pow(radius, 2);
            bunifuTextBox3.Text = area.ToString();
        }
        private void CalculateCircleAreaWithDiameter()
        {
            string diameterInput = bunifuTextBox6.Text;

            if (string.IsNullOrWhiteSpace(diameterInput))
            {
                MessageBox.Show("Diameter must be filled out.");
                return;
            }

            if (!double.TryParse(diameterInput, out double diameter) || diameter <= 0)
            {
                MessageBox.Show("Diameter must be a positive number.");
                return;
            }

            double area = Math.PI * Math.Pow(diameter / 2, 2);
            bunifuTextBox7.Text = area.ToString();
        }
        private void CalculateCircleAreaWithCircumference()
        {
            string circumferenceInput = bunifuTextBox10.Text;

            if (string.IsNullOrWhiteSpace(circumferenceInput))
            {
                MessageBox.Show("Circumference must be filled out.");
                return;
            }

            if (!double.TryParse(circumferenceInput, out double circumference) || circumference <= 0)
            {
                MessageBox.Show("Circumference must be a positive number.");
                return;
            }

            double area = Math.Pow(circumference, 2) / (4 * Math.PI);
            bunifuTextBox11.Text = area.ToString();
        }
        private void CalculateSectorArea()
        {
            string radiusInput = bunifuTextBox13.Text;
            string angleInput = bunifuTextBox2.Text;

            if (string.IsNullOrWhiteSpace(radiusInput) || string.IsNullOrWhiteSpace(angleInput))
            {
                MessageBox.Show("All fields must be filled out.");
                return;
            }

            if (!double.TryParse(radiusInput, out double radius) || radius <= 0 ||
                !double.TryParse(angleInput, out double angle) || angle <= 0)
            {
                MessageBox.Show("Radius and angle must be positive numbers.");
                return;
            }

            double area = 0.5 * Math.Pow(radius, 2) * angle;
            bunifuTextBox12.Text = area.ToString();
        }


        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                CalculateCircleAreaWithRadius();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                CalculateCircleAreaWithDiameter();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                CalculateCircleAreaWithCircumference();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                CalculateSectorArea();
            }
            else
            {
                
            }
        }

        private void circle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}



