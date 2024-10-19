using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApplication3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            clear_screen = false;
            first_number = 0;
            label1.Text = "0";
        }

        char proces_type;
        bool clear_screen;
        double first_number;

        private void btnC_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            clear_screen = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (clear_screen)
            {
                label1.Text = "";
                clear_screen = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (clear_screen)
            {
                label1.Text = "";
                clear_screen = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (clear_screen)
            {
                label1.Text = "";
                clear_screen = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (clear_screen)
            {
                label1.Text = "";
                clear_screen = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (clear_screen)
            {
                label1.Text = "";
                clear_screen = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (clear_screen)
            {
                label1.Text = "";
                clear_screen = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (clear_screen)
            {
                label1.Text = "";
                clear_screen = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (clear_screen)
            {
                label1.Text = "";
                clear_screen = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (clear_screen)
            {
                label1.Text = "";
                clear_screen = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (clear_screen)
            {
                label1.Text = "";
                clear_screen = false;
            }
            if (label1.Text != "0")
            {
                label1.Text += "0";
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            proces_type = '-';
            clear_screen = true;
            first_number = Convert.ToDouble(label1.Text);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            proces_type = '+';
            clear_screen = true;
            first_number = Convert.ToDouble(label1.Text);
        }

        private void btnMultiplaction_Click(object sender, EventArgs e)
        {
            proces_type = 'x';
            clear_screen = true;
            first_number = Convert.ToDouble(label1.Text);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            proces_type = '/';
            clear_screen = true;
            first_number = Convert.ToDouble(label1.Text);
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double second_number = Convert.ToDouble(label1.Text);
            double result = 0;

            switch (proces_type)
            {
                case '+':
                    result = first_number + second_number;
                    break;
                case '-':
                    result = first_number - second_number;
                    break;
                case 'x':
                    result = first_number * second_number;
                    break;
                case '/':
                    if (second_number != 0)
                    {
                        result = first_number / second_number;
                    }
                    else
                    {
                        MessageBox.Show("Bölme işlemi sırasında sıfıra bölünemez.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        result = 0;
                    }
                    break;
                default:
                    result = 0;
                    break;
            }

            label1.Text = result.ToString();
            clear_screen = true;
        }
    }
}
