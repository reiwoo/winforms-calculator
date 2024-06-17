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
    public partial class kite : Form
    {
        public kite()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            this.MouseDown += new MouseEventHandler(kite_MouseDown);
            this.tabPage1.MouseDown += new MouseEventHandler(kite_MouseDown);
            this.tabPage2.MouseDown += new MouseEventHandler(kite_MouseDown);
            this.tabPage3.MouseDown += new MouseEventHandler(kite_MouseDown);
            this.tabPage4.MouseDown += new MouseEventHandler(kite_MouseDown);
            this.tabPage5.MouseDown += new MouseEventHandler(kite_MouseDown);
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
            painter.LaTeX = @"Formula: S=absin(x)";
            painter.TextColor = new SKColor(215, 241, 241);
            painter.WrapColor(100);
            painter.Draw(e.Surface.Canvas);
        }

        private void skControl2_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs e)
        {
            var painter = new CSharpMath.SkiaSharp.MathPainter();
            painter.LaTeX = @"Formula: S=\frac{1}{2}[x_{1}(y_{2}-y_{3})+x_{2}(y_{3}-y_{1})+x_{3}(y_{1}-y_{2})]";
            painter.TextColor = new SKColor(215, 241, 241);
            painter.WrapColor(100);
            painter.Draw(e.Surface.Canvas);
        }

        private void skControl3_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs e)
        {
            var painter = new CSharpMath.SkiaSharp.MathPainter();
            painter.LaTeX = @"Formula: S=\sqrt{p(p-a)(p-b)(p-c)}";
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
        
        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                CalculateKiteAreaWithSidesAndAngles();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
               
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                
            }
            else if (comboBox1.SelectedIndex == 3)
            {
               
            }
            else
            {
               
            }
        }
        private void CalculateKiteAreaWithSidesAndAngles()
        {
            string sideAInput = bunifuTextBox1.Text;
            string sideBInput = bunifuTextBox2.Text;
            string angleInput = bunifuTextBox17.Text;

            if (string.IsNullOrWhiteSpace(sideAInput) || string.IsNullOrWhiteSpace(sideBInput) || string.IsNullOrWhiteSpace(angleInput))
            {
                MessageBox.Show("All fields must be filled out.");
                return;
            }

            if (!double.TryParse(sideAInput, out double sideA) || sideA <= 0 ||
                !double.TryParse(sideBInput, out double sideB) || sideB <= 0 ||
                !double.TryParse(angleInput, out double angle) || angle <= 0)
            {
                MessageBox.Show("Side lengths and angle must be positive numbers.");
                return;
            }

            double area = sideA * sideB * Math.Sin(angle);
            bunifuTextBox3.Text = area.ToString();
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void kite_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}



