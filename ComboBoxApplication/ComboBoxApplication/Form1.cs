using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            string job, language;
            job=comboBox1.SelectedItem.ToString();
            language=listBox1.SelectedItem.ToString();

            MessageBox.Show("You are " +job + " You use "+language );
        }
    }
}
