using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLogIn
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random rastgele=new Random(); // kesin sinavda var 
        int r1, r2, r3;
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            r1=rastgele.Next(1, 5);
            r2=rastgele.Next(1, 5);
            r3=rastgele.Next(1, 5);

            bunifuCircleProgress1.Value +=r1;
            bunifuCircleProgress2.Value +=r2;
            bunifuCircleProgress3.Value +=r3;

            if (bunifuCircleProgress1.Value>=95 || bunifuCircleProgress2.Value>=95 || bunifuCircleProgress3.Value>=95)
            {
                timer1.Stop();
                if(bunifuCircleProgress1.Value>bunifuCircleProgress2.Value && bunifuCircleProgress1.Value>bunifuCircleProgress3.Value)
                {
                    MessageBox.Show("Selected was won A Group");
                }
                else if (bunifuCircleProgress2.Value>bunifuCircleProgress1.Value && bunifuCircleProgress2.Value>bunifuCircleProgress3.Value)
                {
                    MessageBox.Show("Selected was won B Group");
                }
                else
                {
                    MessageBox.Show("Selected was won C Group");
                }
                bunifuCircleProgress1.Value=0;
                bunifuCircleProgress2.Value=0;
                bunifuCircleProgress3.Value=0;


            }
        }
    }
}
