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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = "derya";
            int password = 12345;
            int counter = 0;

            if (username== userNameTextBox.Text && password == Convert.ToInt32(passwordTextBox.Text))
            {
                MessageBox.Show(" Congrulations!!! Username and Password  are True....", "Sign In Panel", MessageBoxButtons.OK);

                userNameTextBox.Clear();
                passwordTextBox.Clear();

                Form1 form1 = new Form1();
                this.Hide();


                Form2 form = new Form2();
                form.Show();
            }
            else if (username != userNameTextBox.Text && password != Convert.ToInt32(passwordTextBox.Text))
            {
                counter++;
                MessageBox.Show("Error ", "Try again please ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (counter == 3)
                {
                    MessageBox.Show(" You entered the wrong password 3 times.", "Sign In Panel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }

            }
        }
        }
}
