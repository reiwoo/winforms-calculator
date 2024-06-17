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
    public partial class trapezoid : Form
    {
        public trapezoid()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            this.MouseDown += new MouseEventHandler(trapezoid_MouseDown);
            this.tabPage1.MouseDown += new MouseEventHandler(trapezoid_MouseDown);
            this.tabPage2.MouseDown += new MouseEventHandler(trapezoid_MouseDown);
            this.tabPage3.MouseDown += new MouseEventHandler(trapezoid_MouseDown);
            this.tabPage4.MouseDown += new MouseEventHandler(trapezoid_MouseDown);
            this.tabPage5.MouseDown += new MouseEventHandler(trapezoid_MouseDown);
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
            painter.LaTeX = @"Formula: S=\frac{1}{2}(a+b)h";
            painter.TextColor = new SKColor(215, 241, 241);
            painter.WrapColor(100);
            painter.Draw(e.Surface.Canvas);
        }

        private void skControl2_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs e)
        {
            var painter = new CSharpMath.SkiaSharp.MathPainter();
            painter.LaTeX = @"Formula: S=mh";
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
            painter.LaTeX = @"Formula: S=mh";
            painter.TextColor = new SKColor(215, 241, 241);
            painter.WrapColor(100);
            painter.Draw(e.Surface.Canvas);
        }

        private void skControl5_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs e)
        {
            var painter = new CSharpMath.SkiaSharp.MathPainter();
            painter.LaTeX = @"Formula: S=\frac{1}{2}d_{1}d_{2}sin(x)";
            painter.TextColor = new SKColor(215, 241, 241);
            painter.WrapColor(100);
            painter.Draw(e.Surface.Canvas);

        }
        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CalculateTrapezoidArea()
        {
            string baseAInput = bunifuTextBox1.Text;
            string baseBInput = bunifuTextBox2.Text;
            string heightInput = bunifuTextBox17.Text;

            if (string.IsNullOrWhiteSpace(baseAInput) || string.IsNullOrWhiteSpace(baseBInput) || string.IsNullOrWhiteSpace(heightInput))
            {
                MessageBox.Show("All fields must be filled out.");
                return;
            }

            if (!double.TryParse(baseAInput, out double baseA) || baseA <= 0 ||
                !double.TryParse(baseBInput, out double baseB) || baseB <= 0 ||
                !double.TryParse(heightInput, out double height) || height <= 0)
            {
                MessageBox.Show("Inputs must be positive numbers.");
                return;
            }

            double area = 0.5 * (baseA + baseB) * height;
            bunifuTextBox3.Text = area.ToString();
        }
        private void CalculateTrapezoidAreaWithMidline()
        {
            string midlineInput = bunifuTextBox6.Text;
            string heightInput = bunifuTextBox5.Text;

            if (string.IsNullOrWhiteSpace(midlineInput) || string.IsNullOrWhiteSpace(heightInput))
            {
                MessageBox.Show("All fields must be filled out.");
                return;
            }

            if (!double.TryParse(midlineInput, out double midline) || midline <= 0 ||
                !double.TryParse(heightInput, out double height) || height <= 0)
            {
                MessageBox.Show("Inputs must be positive numbers.");
                return;
            }

            double area = midline * height;
            bunifuTextBox7.Text = area.ToString();
        }
        private void CalculateTrapezoidAreaWithDiagonals()
        {
            string diagonal1Input = bunifuTextBox10.Text;
            string diagonal2Input = bunifuTextBox9.Text;
            string angleInput = bunifuTextBox8.Text;

            if (string.IsNullOrWhiteSpace(diagonal1Input) || string.IsNullOrWhiteSpace(diagonal2Input) || string.IsNullOrWhiteSpace(angleInput))
            {
                MessageBox.Show("All fields must be filled out.");
                return;
            }

            if (!double.TryParse(diagonal1Input, out double diagonal1) || diagonal1 <= 0 ||
                !double.TryParse(diagonal2Input, out double diagonal2) || diagonal2 <= 0 ||
                !double.TryParse(angleInput, out double angle) || angle <= 0 || angle >= 180)
            {
                MessageBox.Show("Inputs must be positive numbers and the angle must be between 0 and 180 degrees.");
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
                CalculateTrapezoidArea();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                CalculateTrapezoidAreaWithMidline();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                CalculateTrapezoidAreaWithDiagonals();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
               
            }
            else
            {
               
            }
        }


        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void trapezoid_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}



