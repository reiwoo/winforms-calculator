using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProjectToG
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            this.panel1.MouseDown += new MouseEventHandler(Calculator_MouseDown);
            this.tabPage1.MouseDown += new MouseEventHandler(Calculator_MouseDown);
            this.tabPage4.MouseDown += new MouseEventHandler(Calculator_MouseDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Calculator_MouseDown);
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void Calculator_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void btn_area2D_Click(object sender, EventArgs e)
        {
            pages.SetPage(0);
        }

        private void btn_area3D_Click(object sender, EventArgs e)
        {
            pages.SetPage(1);
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {
            string searchText = bunifuTextBox1.Text.ToLower();

            foreach (Control control in flowLayoutPanel.Controls)
            {
                if (control is Bunifu.UI.WinForms.BunifuUserControl userControl)
                {
                    userControl.Visible = userControl.Name.ToLower().Contains(searchText);
                }
            }
        }

        private void bunifuTextBox2_TextChange(object sender, EventArgs e)
        {
            string searchText = bunifuTextBox2.Text.ToLower();

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Bunifu.UI.WinForms.BunifuUserControl userControl)
                {
                    userControl.Visible = userControl.Name.ToLower().Contains(searchText);
                }
            }
        }
    }
}
