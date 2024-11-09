using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ArrayList items = new ArrayList() { "Seçenek 1", "Seçenek 2", "Seçenek 3", "Seçenek 4" };

            // Listeyi ComboBox'a ekle
            comboBox1.DataSource = items;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
