﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Add("Your Path:"+fromcombo.Text+ "---->>>"+tocombo.Text+"date"+date+"time"+time);

            if (radioFemale.Checked) {
                listBox1.Items.Add("Name:"+namebox+"Tc Id:"+idBox+"phone number:"+phoneBox);

            }
            else
            {
             listBox1.Items.Add("Name:"+namebox+"Tc Id:"+idBox+"phone number:"+phoneBox);

            }
        }
    }
}
