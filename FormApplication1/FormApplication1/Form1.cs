using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            ColorDialog color=new ColorDialog();
            color.ShowDialog();
            colourTextBox.BackColor = color.Color;
            color.Reset();

            
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); 
            progressBar1.Value = 10;
            

        }
    }
}
