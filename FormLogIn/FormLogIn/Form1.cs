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

namespace FormLogIn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string name ="derya";
          int password=123456;

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (name == bunifuTextBox1.Text &&  password == Convert.ToInt32(bunifuTextBox2.Text))
            {
                MessageBox.Show("Congrulations !! name and password are true ... ", "Sign in Panel ", MessageBoxButtons.OK);


                Form1 form = new Form1();
                this.Hide();
                Form2 form2 = new Form2();
                form2.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("name and password are wrong.... ", "Sign in panel ", MessageBoxButtons.OK);
            }
            

        }
    }
}
