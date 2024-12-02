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

namespace BookSellApplication
{
    public partial class Form2 : Form
    {
        [DllImport("Gdi32.dll",EntryPoint ="CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse);

        public Form2()
        {
            InitializeComponent();
            Region=System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panelNav.Height=btnDashboard.Height;
            panelNav.Top=btnDashboard.Top;
            panelNav.Left=btnDashboard.Left;
            btnDashboard.BackColor=Color.FromArgb(146, 158, 173);
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panelNav.Height=btnDashboard.Height;
            panelNav.Top=btnDashboard.Top;
            panelNav.Left=btnDashboard.Left;
            btnDashboard.BackColor=Color.FromArgb(146, 158, 173);
            
       
        }

        private void btnAnalytic_Click(object sender, EventArgs e)
        {

            panelNav.Height=btnAnalytic.Height;
            panelNav.Top=btnAnalytic.Top;
            btnAnalytic.BackColor=Color.FromArgb(146, 158, 173);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            panelNav.Height=btnAddUser.Height;
            panelNav.Top=btnAddUser.Top;
            btnAddUser.BackColor=Color.FromArgb(146, 158, 173);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panelNav.Height=btnSettings.Height;
            panelNav.Top=btnSettings.Top;
            btnSettings.BackColor=Color.FromArgb(146, 158, 173);
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor=Color.FromArgb(135, 206, 235);
        }

        private void btnAnalytic_Leave(object sender, EventArgs e)
        {
            btnAnalytic.BackColor=Color.FromArgb(135, 206, 235);
        }

        private void btnAddUser_Leave(object sender, EventArgs e)
        {
            btnAddUser.BackColor=Color.FromArgb(135, 206, 235);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
           btnSettings.BackColor=Color.FromArgb(135, 206, 235);
        }
    }
}
