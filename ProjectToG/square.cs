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
    public partial class square : Form
    {
        public square()
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
            painter.LaTeX = @"Formula: S=a^{2}";
            painter.TextColor = new SKColor(215, 241, 241);
            painter.WrapColor(100);
            painter.Draw(e.Surface.Canvas);
        }

        private void skControl2_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs e)
        {
            var painter = new CSharpMath.SkiaSharp.MathPainter();
            painter.LaTeX = @"Formula: S=\frac{d^{2}}{2}";
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

            double area = Math.Pow(side, 2);
            bunifuTextBox3.Text = area.ToString();
        }
        private void calculateDiagonal()
        {
            string diagonalText = bunifuTextBox6.Text;

            if (string.IsNullOrEmpty(diagonalText))
            {
                MessageBox.Show("Please enter the diagonal length of the square.");
                return;
            }

            if (!double.TryParse(diagonalText, out double diagonal))
            {
                MessageBox.Show("Please enter a valid numeric value for the diagonal length.");
                return;
            }

            if (diagonal < 0)
            {
                MessageBox.Show("Diagonal length cannot be negative.");
                return;
            }

            double area = Math.Pow(diagonal, 2) / 2;
            bunifuTextBox7.Text = area.ToString();  
            
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                calculateGeneral();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                calculateDiagonal();
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
    }
}



