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
    public partial class parallelepiped : Form
    {
        public parallelepiped()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            this.MouseDown += new MouseEventHandler(parallelepiped_MouseDown);
            this.tabPage1.MouseDown += new MouseEventHandler(parallelepiped_MouseDown);
            this.tabPage2.MouseDown += new MouseEventHandler(parallelepiped_MouseDown);
            this.tabPage3.MouseDown += new MouseEventHandler(parallelepiped_MouseDown);
            this.tabPage4.MouseDown += new MouseEventHandler(parallelepiped_MouseDown);
            this.tabPage5.MouseDown += new MouseEventHandler(parallelepiped_MouseDown);
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
            painter.LaTeX = @"Formula: V = lwh";
            painter.TextColor = new SKColor(215, 241, 241);
            painter.WrapColor(100);
            painter.Draw(e.Surface.Canvas);
        }

        private void skControl2_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs e)
        {
            var painter = new CSharpMath.SkiaSharp.MathPainter();
            painter.LaTeX = @"Formula: V = Ah";
            painter.TextColor = new SKColor(215, 241, 241);
            painter.WrapColor(100);
            painter.Draw(e.Surface.Canvas);
        }

        private void skControl3_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs e)
        {
            var painter = new CSharpMath.SkiaSharp.MathPainter();
            painter.LaTeX = @"Formula: V = (\sqrt{d^{2}-h^{2}-w^{2}})hw";
            painter.TextColor = new SKColor(215, 241, 241);
            painter.WrapColor(100);
            painter.Draw(e.Surface.Canvas);
        }

        private void skControl4_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs e)
        {
            var painter = new CSharpMath.SkiaSharp.MathPainter();
            painter.LaTeX = @"Formula: V = (\frac{P}{4})^{2}h";
            painter.TextColor = new SKColor(215, 241, 241);
            painter.WrapColor(100);
            painter.Draw(e.Surface.Canvas);
        }

        private void skControl5_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs e)
        {
            var painter = new CSharpMath.SkiaSharp.MathPainter();
            painter.LaTeX = @"Formula: V = A'l";
            painter.TextColor = new SKColor(215, 241, 241);
            painter.WrapColor(100);
            painter.Draw(e.Surface.Canvas);

        }
        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CalculateVolumeUsingLWH()
        {
            string lengthInput = bunifuTextBox18.Text;
            string widthInput = bunifuTextBox3.Text;
            string heightInput = bunifuTextBox1.Text;

            if (string.IsNullOrWhiteSpace(lengthInput) || string.IsNullOrWhiteSpace(widthInput) || string.IsNullOrWhiteSpace(heightInput))
            {
                MessageBox.Show("Length, width, and height must be filled out.");
                return;
            }

            if (!double.TryParse(lengthInput, out double length) || length <= 0 ||
                !double.TryParse(widthInput, out double width) || width <= 0 ||
                !double.TryParse(heightInput, out double height) || height <= 0)
            {
                MessageBox.Show("Length, width, and height must be positive numbers.");
                return;
            }

            double volume = length * width * height;
            bunifuTextBox2.Text = volume.ToString();

        }
        private void CalculateVolumeUsingBaseAreaAndHeight()
        {
            string baseAreaInput = bunifuTextBox6.Text;
            string heightInput = bunifuTextBox5.Text;

            if (string.IsNullOrWhiteSpace(baseAreaInput) || string.IsNullOrWhiteSpace(heightInput))
            {
                MessageBox.Show("Base area and height must be filled out.");
                return;
            }

            if (!double.TryParse(baseAreaInput, out double baseArea) || baseArea <= 0 ||
                !double.TryParse(heightInput, out double height) || height <= 0)
            {
                MessageBox.Show("Base area and height must be positive numbers.");
                return;
            }

            double volume = baseArea * height;
            bunifuTextBox7.Text = volume.ToString();
        }
        private void CalculateVolumeUsingDiagonalAndHeight()
        {
            string diagonalInput = bunifuTextBox10.Text;
            string heightInput = bunifuTextBox9.Text;
            string widthInput = bunifuTextBox17.Text;

            if (string.IsNullOrWhiteSpace(diagonalInput) || string.IsNullOrWhiteSpace(heightInput) || string.IsNullOrWhiteSpace(widthInput))
            {
                MessageBox.Show("Diagonal, width, and height must be filled out.");
                return;
            }

            if (!double.TryParse(diagonalInput, out double diagonal) || diagonal <= 0 ||
                !double.TryParse(heightInput, out double height) || height <= 0 ||
                !double.TryParse(widthInput, out double width) || width <= 0)
            {
                MessageBox.Show("Diagonal, width, and height must be positive numbers.");
                return;
            }

            double length = Math.Sqrt(diagonal * diagonal - height * height - width * width);
            double volume = length * width * height;
            bunifuTextBox11.Text = volume.ToString();
        }
        private void CalculateVolumeUsingPerimeterAndHeight()
        {
            string perimeterInput = bunifuTextBox13.Text;
            string heightInput = bunifuTextBox19.Text;

            if (string.IsNullOrWhiteSpace(perimeterInput) || string.IsNullOrWhiteSpace(heightInput))
            {
                MessageBox.Show("Perimeter and height must be filled out.");
                return;
            }

            if (!double.TryParse(perimeterInput, out double perimeter) || perimeter <= 0 ||
                !double.TryParse(heightInput, out double height) || height <= 0)
            {
                MessageBox.Show("Perimeter and height must be positive numbers.");
                return;
            }

            double length = perimeter / 4;
            double width = length;
            double volume = length * width * height;
            bunifuTextBox12.Text = volume.ToString();
        }
        private void CalculateVolumeUsingCrossSectionalAreaAndLength()
        {
            string crossSectionalAreaInput = bunifuTextBox16.Text;
            string lengthInput = bunifuTextBox15.Text;

            if (string.IsNullOrWhiteSpace(crossSectionalAreaInput) || string.IsNullOrWhiteSpace(lengthInput))
            {
                MessageBox.Show("Cross-sectional area and length must be filled out.");
                return;
            }

            if (!double.TryParse(crossSectionalAreaInput, out double crossSectionalArea) || crossSectionalArea <= 0 ||
                !double.TryParse(lengthInput, out double length) || length <= 0)
            {
                MessageBox.Show("Cross-sectional area and length must be positive numbers.");
                return;
            }

            double volume = crossSectionalArea * length;
            bunifuTextBox14.Text = volume.ToString();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                CalculateVolumeUsingLWH();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                CalculateVolumeUsingBaseAreaAndHeight();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                CalculateVolumeUsingDiagonalAndHeight();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                CalculateVolumeUsingPerimeterAndHeight();
            }
            else
            {
                CalculateVolumeUsingCrossSectionalAreaAndLength();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void parallelepiped_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}



