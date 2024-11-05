using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizQuestion_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Show_Click(object sender, EventArgs e)
        {
            
            string text = listBox1.SelectedItem.ToString();
            MessageBox.Show("Selected items:"+text,"Information",MessageBoxButtons.OK);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] dizi = { "C#", "Java ", "Python" };
            foreach (string list in dizi)
            {
                listBox1.Items.Add(list);
            }
        }
    }
}
