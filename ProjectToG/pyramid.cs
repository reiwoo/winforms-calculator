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
    public partial class pyramid : Form
    {
        public pyramid()
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
            painter.LaTeX = @"Formula: V = \frac{1}{3}a^{2}h";
            painter.TextColor = new SKColor(215, 241, 241);
            painter.WrapColor(100);
            painter.Draw(e.Surface.Canvas);
        }

        private void skControl2_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs e)
        {
            var painter = new CSharpMath.SkiaSharp.MathPainter();
            painter.LaTeX = @"Formula: V = \frac{1}{3}Ah";
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
        private void CalculateVolumeUsingBaseAndHeight()
        {
            string baseSideInput = bunifuTextBox1.Text;
            string heightInput = bunifuTextBox2.Text;

            if (string.IsNullOrWhiteSpace(baseSideInput) || string.IsNullOrWhiteSpace(heightInput))
            {
                MessageBox.Show("Base side length and height must be filled out.");
                return;
            }

            if (!double.TryParse(baseSideInput, out double baseSide) || baseSide <= 0)
            {
                MessageBox.Show("Base side length must be a positive number.");
                return;
            }

            if (!double.TryParse(heightInput, out double height) || height <= 0)
            {
                MessageBox.Show("Height must be a positive number.");
                return;
            }

            double volume = (1.0 / 3.0) * Math.Pow(baseSide, 2) * height;
            bunifuTextBox3.Text = volume.ToString();
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

            if (!double.TryParse(baseAreaInput, out double baseArea) || baseArea <= 0)
            {
                MessageBox.Show("Base area must be a positive number.");
                return;
            }

            if (!double.TryParse(heightInput, out double height) || height <= 0)
            {
                MessageBox.Show("Height must be a positive number.");
                return;
            }

            double volume = (1.0 / 3.0) * baseArea * height;
            bunifuTextBox7.Text = volume.ToString();
        }


        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                CalculateVolumeUsingBaseAndHeight();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                CalculateVolumeUsingBaseAreaAndHeight();
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



