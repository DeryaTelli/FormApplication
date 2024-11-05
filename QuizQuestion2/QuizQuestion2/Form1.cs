using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizQuestion2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32((numberText.Text));
            int result=Convert.ToInt32(resultLabel.Text);
            if (squareRadio.Checked)
            {
                result=Convert.ToInt32(Math.Pow(number, 2));
            }
            else if (cupeRadio.Checked) {
                result=Convert.ToInt32(Math.Pow(number, 3));
            }
            else
            {
                MessageBox.Show("please selected radiabutton ");
            }
            resultLabel.Text=result.ToString();
        }
    }
}
