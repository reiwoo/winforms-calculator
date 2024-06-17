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
    public partial class tangle : Form
    {
        public tangle()
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
            painter.LaTeX = @"Formula: S=\frac{1}{4}ns^{2}cot(\frac{\pi}{n})";
            painter.TextColor = new SKColor(215, 241, 241);
            painter.WrapColor(100);
            painter.Draw(e.Surface.Canvas);
        }

        private void skControl2_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs e)
        {
            var painter = new CSharpMath.SkiaSharp.MathPainter();
            painter.LaTeX = @"Formula: S=\frac{1}{2}PR";
            painter.TextColor = new SKColor(215, 241, 241);
            painter.WrapColor(100);
            painter.Draw(e.Surface.Canvas);
        }

        private void skControl3_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs e)
        {
            var painter = new CSharpMath.SkiaSharp.MathPainter();
            painter.LaTeX = @"Formula: S=\frac{1}{2}Pr";
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
        private void CalculateRegularPolygonArea()
        {
            string sideLengthInput = bunifuTextBox1.Text;
            string sidesCountInput = bunifuTextBox2.Text;

            if (string.IsNullOrWhiteSpace(sideLengthInput) || string.IsNullOrWhiteSpace(sidesCountInput))
            {
                MessageBox.Show("All fields must be filled out.");
                return;
            }

            if (!double.TryParse(sideLengthInput, out double sideLength) || sideLength <= 0 ||
                !int.TryParse(sidesCountInput, out int sidesCount) || sidesCount < 3)
            {
                MessageBox.Show("Side length must be a positive number and sides count must be at least 3.");
                return;
            }

            double area = (0.25 * sidesCount * Math.Pow(sideLength, 2)) / Math.Tan(Math.PI / sidesCount);
            bunifuTextBox3.Text = area.ToString();

        }
        private void CalculatePolygonAreaWithCircumscribedCircle()
        {
            string perimeterInput = bunifuTextBox6.Text;
            string radiusInput = bunifuTextBox5.Text;

            if (string.IsNullOrWhiteSpace(perimeterInput) || string.IsNullOrWhiteSpace(radiusInput))
            {
                MessageBox.Show("All fields must be filled out.");
                return;
            }

            if (!double.TryParse(perimeterInput, out double perimeter) || perimeter <= 0 ||
                !double.TryParse(radiusInput, out double radius) || radius <= 0)
            {
                MessageBox.Show("Perimeter and radius must be positive numbers.");
                return;
            }

            double area = 0.5 * perimeter * radius;
            bunifuTextBox7.Text = area.ToString();
        }
        private void CalculatePolygonAreaWithInscribedCircle()
        {
            string perimeterInput = bunifuTextBox10.Text;
            string radiusInput = bunifuTextBox9.Text;

            if (string.IsNullOrWhiteSpace(perimeterInput) || string.IsNullOrWhiteSpace(radiusInput))
            {
                MessageBox.Show("All fields must be filled out.");
                return;
            }

            if (!double.TryParse(perimeterInput, out double perimeter) || perimeter <= 0 ||
                !double.TryParse(radiusInput, out double radius) || radius <= 0)
            {
                MessageBox.Show("Perimeter and radius must be positive numbers.");
                return;
            }

            double area = 0.5 * perimeter * radius;
            bunifuTextBox11.Text = area.ToString();
        }


        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                CalculateRegularPolygonArea();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                CalculatePolygonAreaWithCircumscribedCircle();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                CalculatePolygonAreaWithInscribedCircle();
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



