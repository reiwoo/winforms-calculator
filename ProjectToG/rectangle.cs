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


namespace ProjectToG
{
    public partial class rectangle : Form
    {
        public rectangle()
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
            painter.LaTeX = @"Formula: S = ab";
            painter.TextColor = new SKColor(215, 241, 241);
            painter.WrapColor(100);
            painter.Draw(e.Surface.Canvas);
        }

        private void skControl2_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs e)
        {
            var painter = new CSharpMath.SkiaSharp.MathPainter();
            painter.LaTeX = @"Formula: S=side\sqrt{diag^{^{2}}-side^{2}}";
            painter.TextColor = new SKColor(215, 241, 241);
            painter.WrapColor(100);
            painter.Draw(e.Surface.Canvas);
        }

        private void skControl3_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs e)
        {
            var painter = new CSharpMath.SkiaSharp.MathPainter();
            painter.LaTeX = @"Formula: S=\sqrt{(\frac{perimeter}{2})^{2}-(\frac{diagonal}{2})^{2}}";
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
        private void CalculateRectangleArea()
        {
            if (string.IsNullOrWhiteSpace(bunifuTextBox1.Text) || string.IsNullOrWhiteSpace(bunifuTextBox2.Text))
            {
                MessageBox.Show("Please enter values for both length and width.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(bunifuTextBox1.Text, out double length) || !double.TryParse(bunifuTextBox2.Text, out double width))
            {
                MessageBox.Show("Please enter valid numeric values for length and width.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (length <= 0 || width <= 0)
            {
                MessageBox.Show("Length and width must be positive numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double area = length * width;
            bunifuTextBox3.Text = area.ToString();
        }
        private void CalculateRectangleAreaUsingDiagonalAndSide()
        {
            if (string.IsNullOrWhiteSpace(bunifuTextBox6.Text) || string.IsNullOrWhiteSpace(bunifuTextBox5.Text))
            {
                MessageBox.Show("Please enter values for both diagonal and side length.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(bunifuTextBox6.Text, out double diagonal) || !double.TryParse(bunifuTextBox5.Text, out double side))
            {
                MessageBox.Show("Please enter valid numeric values for diagonal and side length.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (diagonal <= 0 || side <= 0)
            {
                MessageBox.Show("Diagonal and side length must be positive numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (diagonal <= side)
            {
                MessageBox.Show("Diagonal must be greater than the side length.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double otherSide = Math.Sqrt(Math.Pow(diagonal, 2) - Math.Pow(side, 2));

            double area = side * otherSide;
            bunifuTextBox7.Text = area.ToString();
        }
        private void CalculateRectangleAreaUsingPerimeterAndDiagonal()
        {
            if (string.IsNullOrWhiteSpace(bunifuTextBox10.Text) || string.IsNullOrWhiteSpace(bunifuTextBox9.Text))
            {
                MessageBox.Show("Please enter values for both perimeter and diagonal.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(bunifuTextBox10.Text, out double perimeter) || !double.TryParse(bunifuTextBox9.Text, out double diagonal))
            {
                MessageBox.Show("Please enter valid numeric values for perimeter and diagonal.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (perimeter <= 0 || diagonal <= 0)
            {
                MessageBox.Show("Perimeter and diagonal must be positive numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double semiPerimeter = perimeter / 2;
            double part1 = Math.Pow(semiPerimeter, 2);
            double part2 = Math.Pow(diagonal, 2);
            double part3 = Math.Sqrt(part1 - part2);
            double length = (semiPerimeter + part3) / 2;
            double width = semiPerimeter - length;

            if (width <= 0)
            {
                MessageBox.Show("Invalid values. Please check the inputs.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double area = length * width;
            bunifuTextBox11.Text = area.ToString();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                CalculateRectangleArea();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                CalculateRectangleAreaUsingDiagonalAndSide();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                CalculateRectangleAreaUsingPerimeterAndDiagonal();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
               
            }
            else
            {
                
            }
        }
    }
}



