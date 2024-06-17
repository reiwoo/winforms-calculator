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
    public partial class sphere : Form
    {
        public sphere() // Mne stalo super len' pereimenovivat'.
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            this.MouseDown += new MouseEventHandler(sphere_MouseDown);
            this.tabPage1.MouseDown += new MouseEventHandler(sphere_MouseDown);
            this.tabPage2.MouseDown += new MouseEventHandler(sphere_MouseDown);
            this.tabPage3.MouseDown += new MouseEventHandler(sphere_MouseDown);
            this.tabPage4.MouseDown += new MouseEventHandler(sphere_MouseDown);
            this.tabPage5.MouseDown += new MouseEventHandler(sphere_MouseDown);
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
            painter.LaTeX = @"Formula: V = \frac{4}{3}\pi r^{3}";
            painter.TextColor = new SKColor(215, 241, 241);
            painter.WrapColor(100);
            painter.Draw(e.Surface.Canvas);
        }

        private void skControl2_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs e)
        {
            var painter = new CSharpMath.SkiaSharp.MathPainter();
            painter.LaTeX = @"Formula: V = \frac{1}{6}\pi d^{3}";
            painter.TextColor = new SKColor(215, 241, 241);
            painter.WrapColor(100);
            painter.Draw(e.Surface.Canvas);
        }

        private void skControl3_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs e)
        {
            var painter = new CSharpMath.SkiaSharp.MathPainter();
            painter.LaTeX = @"Formula: V = \frac{Ar}{3}";
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
        private void calculateGeneral()
        {
            string sideText = bunifuTextBox1.Text;

            if (string.IsNullOrEmpty(sideText))
            {
                MessageBox.Show("Please enter the side length of the square.");
                return;
            }

            if (!double.TryParse(sideText, out double side))
            {
                MessageBox.Show("Please enter a valid numeric value for the side length.");
                return;
            }

            if (side < 0)
            {
                MessageBox.Show("Side length cannot be negative.");
                return;
            }

            double area = 4 / 3 * Math.PI * Math.Pow(side, 3);
            bunifuTextBox3.Text = area.ToString();
        }
        private void calculateGeneral1()
        {
            string sideText = bunifuTextBox6.Text;

            if (string.IsNullOrEmpty(sideText))
            {
                MessageBox.Show("Please enter the side length of the square.");
                return;
            }

            if (!double.TryParse(sideText, out double side))
            {
                MessageBox.Show("Please enter a valid numeric value for the side length.");
                return;
            }

            if (side < 0)
            {
                MessageBox.Show("Side length cannot be negative.");
                return;
            }

            double area = 1 / 6 * Math.PI * Math.Pow(side, 3);
            bunifuTextBox7.Text = area.ToString();
        }
        private void CalculateRhombusAreaWithDiagonals()
        {
            string diagonal1Input = bunifuTextBox10.Text;
            string diagonal2Input = bunifuTextBox9.Text;

            if (string.IsNullOrWhiteSpace(diagonal1Input) || string.IsNullOrWhiteSpace(diagonal2Input))
            {
                MessageBox.Show("All fields must be filled out.");
                return;
            }

            if (!double.TryParse(diagonal1Input, out double diagonal1) || diagonal1 <= 0 ||
                !double.TryParse(diagonal2Input, out double diagonal2) || diagonal2 <= 0)
            {
                MessageBox.Show("Inputs must be positive numbers.");
                return;
            }

            double area = diagonal1 * diagonal2 / 3;
            bunifuTextBox11.Text = area.ToString();
        }
        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                calculateGeneral();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                calculateGeneral1();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                CalculateRhombusAreaWithDiagonals();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                
            }
            else
            {
               
            }
        }

        private void sphere_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}



