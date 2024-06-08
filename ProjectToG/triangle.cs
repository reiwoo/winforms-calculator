using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkiaSharp;

namespace ProjectToG
{
    public partial class triangle : Form
    {
        public triangle()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

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
            painter.LaTeX = @"Formula: S = \frac{1}{2}bh";
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

        }

        private void skControl5_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs e)
        {

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

            double area = 0.5 * baseValue * heightValue;
            bunifuTextBox3.Text = area.ToString();
        }
        private void CalculateCoordinates()
        {
            string point1Text = bunifuTextBox6.Text;
            string point2Text = bunifuTextBox5.Text;
            string point3Text = bunifuTextBox4.Text;

            if (string.IsNullOrWhiteSpace(point1Text) || string.IsNullOrWhiteSpace(point2Text) || string.IsNullOrWhiteSpace(point3Text))
            {
                MessageBox.Show("Coordinates cannot be empty.");
                return;
            }
            // Разделяем значения по разделителю |
            var point1Parts = point1Text.Split('|');
            var point2Parts = point2Text.Split('|');
            var point3Parts = point3Text.Split('|');

            if (point1Parts.Length != 2 || point2Parts.Length != 2 || point3Parts.Length != 2)
            {
                MessageBox.Show("Each point must be in the format x|y.");
                return;
            }

            if (!double.TryParse(point1Parts[0], out double x1) || !double.TryParse(point1Parts[1], out double y1) ||
                !double.TryParse(point2Parts[0], out double x2) || !double.TryParse(point2Parts[1], out double y2) ||
                !double.TryParse(point3Parts[0], out double x3) || !double.TryParse(point3Parts[1], out double y3))
            {
                MessageBox.Show("All coordinates must be valid numbers.");
                return;
            }

            double area = Math.Abs((x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2.0);

            bunifuTextBox7.Text = area.ToString();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                CalculateGeneral();
            }
            else if (comboBox1.SelectedIndex == 1) 
            {
                CalculateCoordinates();
            }
        }
    }
}



