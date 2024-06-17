using Bunifu.UI.WinForms;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace ProjectToG
{
    public partial class parallelogram : Form
    {
        public parallelogram()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            this.MouseDown += new MouseEventHandler(parallelogram_MouseDown);
            this.tabPage1.MouseDown += new MouseEventHandler(parallelogram_MouseDown);
            this.tabPage2.MouseDown += new MouseEventHandler(parallelogram_MouseDown);
            this.tabPage3.MouseDown += new MouseEventHandler(parallelogram_MouseDown);
            this.tabPage4.MouseDown += new MouseEventHandler(parallelogram_MouseDown);
            this.tabPage5.MouseDown += new MouseEventHandler(parallelogram_MouseDown);
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
            painter.LaTeX = @"Formula: S = bh";
            painter.TextColor = new SKColor(215, 241, 241);
            painter.WrapColor(100);
            painter.Draw(e.Surface.Canvas);
        }

        private void skControl2_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs e)
        {
            var painter = new CSharpMath.SkiaSharp.MathPainter();
            painter.LaTeX = @"Formula: S=absin(x)";
            painter.TextColor = new SKColor(215, 241, 241);
            painter.WrapColor(100);
            painter.Draw(e.Surface.Canvas);
        }

        private void skControl3_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs e)
        {
            var painter = new CSharpMath.SkiaSharp.MathPainter();
            painter.LaTeX = @"Formula: S=\frac{1}{2}d_{1}d_{2}sin(x)";
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
        private void CalculateGeneral()
        {
            string b = bunifuTextBox1.Text;
            string h = bunifuTextBox2.Text;

            if (string.IsNullOrWhiteSpace(b) || string.IsNullOrWhiteSpace(h))
            {
                MessageBox.Show("B and H не могут быть пустыми.");
                return;
            }

            if (!double.TryParse(b, out double baseValue) || !double.TryParse(h, out double heightValue))
            {
                MessageBox.Show("B and H must be valid number.");
                return;
            }

            if (baseValue <= 0 || heightValue <= 0)
            {
                MessageBox.Show("B and H must be positive numbers.");
                return;
            }

            double area = baseValue * heightValue;
            bunifuTextBox3.Text = area.ToString();
        }
        private void CalculateAngle()
        {
            string side1Text = bunifuTextBox6.Text; // Длина первой стороны (a)
            string side2Text = bunifuTextBox5.Text; // Длина второй стороны (b)
            string angleText = bunifuTextBox4.Text; // Угол между сторонами (θ)

            if (string.IsNullOrWhiteSpace(side1Text) || string.IsNullOrWhiteSpace(side2Text) || string.IsNullOrWhiteSpace(angleText))
            {
                MessageBox.Show("Side lengths and angle cannot be empty.");
                return;
            }

            if (!double.TryParse(side1Text, out double side1) || !double.TryParse(side2Text, out double side2) || !double.TryParse(angleText, out double angle))
            {
                MessageBox.Show("Side lengths and angle must be valid numbers.");
                return;
            }

            if (side1 <= 0 || side2 <= 0 || angle <= 0 || angle >= 180)
            {
                MessageBox.Show("Side lengths must be positive and angle must be between 0 and 180 degrees.");
                return;
            }

            double angleInRadians = angle * (Math.PI / 180);
            double area = side1 * side2 * Math.Sin(angleInRadians);
            bunifuTextBox7.Text = area.ToString();        
        }
        private void CalculateDiagonals()
        {
            string diagonal1Text = bunifuTextBox10.Text; // Длина первой диагонали (d1)
            string diagonal2Text = bunifuTextBox9.Text; // Длина второй диагонали (d2)
            string angleText = bunifuTextBox8.Text; // Угол между диагоналями (θ)

            if (string.IsNullOrWhiteSpace(diagonal1Text) || string.IsNullOrWhiteSpace(diagonal2Text) || string.IsNullOrWhiteSpace(angleText))
            {
                MessageBox.Show("Diagonal lengths and angle cannot be empty.");
                return;
            }

            if (!double.TryParse(diagonal1Text, out double diagonal1) || !double.TryParse(diagonal2Text, out double diagonal2) || !double.TryParse(angleText, out double angle))
            {
                MessageBox.Show("Diagonal lengths and angle must be valid numbers.");
                return;
            }

            if (diagonal1 <= 0 || diagonal2 <= 0 || angle <= 0 || angle >= 180)
            {
                MessageBox.Show("Diagonal lengths must be positive and angle must be between 0 and 180 degrees.");
                return;
            }

            double angleInRadians = angle * (Math.PI / 180);
            double area = 0.5 * diagonal1 * diagonal2 * Math.Sin(angleInRadians);

            bunifuTextBox11.Text = area.ToString();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                CalculateGeneral();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                CalculateAngle();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                CalculateDiagonals();
            }
        }

        private void parallelogram_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}



