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
    public partial class FormulaItem : Bunifu.UI.WinForms.BunifuUserControl
    {
        private triangle triangleForm;
        public FormulaItem()
        {
            InitializeComponent();

        }
        public PictureBox ImagePictureBox
        {
            get { return pictureBox1; }
        }

        private void FormulaItem_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouseArgs = e as MouseEventArgs;
            Point clickLocation = mouseArgs.Location;

            // Проверяем, был ли клик выполнен в пределах непрозрачной области изображения
            if (IsWithinOpaqueArea(clickLocation))
            {
                // Открываем дочернюю форму
                if (triangleForm == null || triangleForm.IsDisposed)
                {
                    // Создаем новую форму и сохраняем ссылку на нее
                    triangleForm = new triangle();
                    triangleForm.Show();
                }
                else
                {
                    // Если форма уже открыта, делаем ее активной
                    triangleForm.BringToFront();
                }
            }
        }
        private bool IsWithinOpaqueArea(Point clickLocation)
        {
            // Получаем размеры изображения
            int imageWidth = pictureBox1.Image.Width;
            int imageHeight = pictureBox1.Image.Height;

            // Проверяем, находятся ли координаты клика в пределах изображения
            if (clickLocation.X >= 0 && clickLocation.X < imageWidth && clickLocation.Y >= 0 && clickLocation.Y < imageHeight)
            {
                // Получаем цвет пикселя, на который был произведен клик
                Color pixelColor = ((Bitmap)pictureBox1.Image).GetPixel(clickLocation.X, clickLocation.Y);

                // Проверяем, прозрачен ли пиксель
                return pixelColor.A > 0; // Если альфа-канал пикселя не равен 0, это значит, что он непрозрачен
            }

            return false; // Клик был за пределами изображения
        }
    }
}
