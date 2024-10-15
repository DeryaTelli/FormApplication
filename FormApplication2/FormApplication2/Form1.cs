using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void writeButton_Click(object sender, EventArgs e)
        {
            string text= textBox1.Text;
            listBox1.Items.Add(text);

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void writeComboButton_Click(object sender, EventArgs e)
        {
            string textCombo = textBox1.Text;   
            comboBox1.Items.Add(textCombo);
        }

        private void deleteComboButton_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            
        }

        private void ComboListButton_Click(object sender, EventArgs e)
        {
            string combo =comboBox1.SelectedItem.ToString();
            listBox1.Items.Add((string)combo);
        }
    }
}
