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
    public partial class cube : Form
    {
        public cube()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            this.MouseDown += new MouseEventHandler(cube_MouseDown);
            this.tabPage1.MouseDown += new MouseEventHandler(cube_MouseDown);
            this.tabPage2.MouseDown += new MouseEventHandler(cube_MouseDown);
            this.tabPage3.MouseDown += new MouseEventHandler(cube_MouseDown);
            this.tabPage4.MouseDown += new MouseEventHandler(cube_MouseDown);
            this.tabPage5.MouseDown += new MouseEventHandler(cube_MouseDown);
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
            painter.LaTeX = @"Formula: V = a^{3}";
            painter.TextColor = new SKColor(215, 241, 241);
            painter.WrapColor(100);
            painter.Draw(e.Surface.Canvas);
        }

        private void skControl2_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs e)
        {
            var painter = new CSharpMath.SkiaSharp.MathPainter();
            painter.LaTeX = @"Formula: V = (\frac{d}{\sqrt{2}})^{3}";
            painter.TextColor = new SKColor(215, 241, 241);
            painter.WrapColor(100);
            painter.Draw(e.Surface.Canvas);
        }

        private void skControl3_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs e)
        {
            var painter = new CSharpMath.SkiaSharp.MathPainter();
            painter.LaTeX = @"Formula: V = (\frac{D}{\sqrt{3}})^{3}";
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
        private void CalculateVolumeUsingSideLength()
        {
            string sideLengthInput = bunifuTextBox1.Text;

            if (string.IsNullOrWhiteSpace(sideLengthInput))
            {
                MessageBox.Show("Side length must be filled out.");
                return;
            }

            if (!double.TryParse(sideLengthInput, out double sideLength) || sideLength <= 0)
            {
                MessageBox.Show("Side length must be a positive number.");
                return;
            }

            double volume = Math.Pow(sideLength, 3);
            bunifuTextBox3.Text = volume.ToString();
        }
        private void CalculateVolumeUsingFaceDiagonal()
        {
            string faceDiagonalInput = bunifuTextBox6.Text;

            if (string.IsNullOrWhiteSpace(faceDiagonalInput))
            {
                MessageBox.Show("Face diagonal must be filled out.");
                return;
            }

            if (!double.TryParse(faceDiagonalInput, out double faceDiagonal) || faceDiagonal <= 0)
            {
                MessageBox.Show("Face diagonal must be a positive number.");
                return;
            }

            double sideLength = faceDiagonal / Math.Sqrt(2);
            double volume = Math.Pow(sideLength, 3);
            bunifuTextBox7.Text = volume.ToString();
        }
        private void CalculateVolumeUsingSpaceDiagonal()
        {
            string spaceDiagonalInput = bunifuTextBox10.Text;

            if (string.IsNullOrWhiteSpace(spaceDiagonalInput))
            {
                MessageBox.Show("Space diagonal must be filled out.");
                return;
            }

            if (!double.TryParse(spaceDiagonalInput, out double spaceDiagonal) || spaceDiagonal <= 0)
            {
                MessageBox.Show("Space diagonal must be a positive number.");
                return;
            }

            double sideLength = spaceDiagonal / Math.Sqrt(3);
            double volume = Math.Pow(sideLength, 3);
            bunifuTextBox11.Text = volume.ToString();
        }
        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                CalculateVolumeUsingSideLength();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                CalculateVolumeUsingFaceDiagonal();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                CalculateVolumeUsingSpaceDiagonal();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                
            }
            else
            {
                
            }
        }

        private void cube_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}



