﻿using System;
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
    public partial class area_pyramid : Bunifu.UI.WinForms.BunifuUserControl
    {
        private pyramid pyramidForm;
        public area_pyramid()
        {
            InitializeComponent();
        }
        private void FormulaItem_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouseArgs = e as MouseEventArgs;
            Point clickLocation = mouseArgs.Location;
            if (IsWithinOpaqueArea(clickLocation))
            {
                if (pyramidForm == null || pyramidForm.IsDisposed)
                {
                    pyramidForm = new pyramid();
                    pyramidForm.Show();
                }
                else
                {
                    pyramidForm.BringToFront();
                }
            }
        }
        private bool IsWithinOpaqueArea(Point clickLocation)
        {
            int imageWidth = pictureBox1.Image.Width;
            int imageHeight = pictureBox1.Image.Height;
            if (clickLocation.X >= 0 && clickLocation.X < imageWidth && clickLocation.Y >= 0 && clickLocation.Y < imageHeight)
            {
                Color pixelColor = ((Bitmap)pictureBox1.Image).GetPixel(clickLocation.X, clickLocation.Y);
                return pixelColor.A > 0;
            }

            return false;
        }
    }
}
