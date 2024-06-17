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
    public partial class prism : Form
    {
        public prism()
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
            painter.LaTeX = @"Formula: V = Sh";
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
        private void CalculateTriangularPrismVolume()
        {
            string areaInput = bunifuTextBox1.Text;
            string heightInput = bunifuTextBox2.Text;

            if (string.IsNullOrWhiteSpace(areaInput) || string.IsNullOrWhiteSpace(heightInput))
            {
                MessageBox.Show("Please enter both the area of the base and the height of the prism.");
                return;
            }

            if (!double.TryParse(areaInput, out double area) || !double.TryParse(heightInput, out double height))
            {
                MessageBox.Show("Please enter valid numeric values.");
                return;
            }

            if (area <= 0 || height <= 0)
            {
                MessageBox.Show("Both the area and the height must be positive values.");
                return;
            }

            double volume = area * height;
            bunifuTextBox3.Text = volume.ToString();    
        }


        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                CalculateTriangularPrismVolume();
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
    }
}



