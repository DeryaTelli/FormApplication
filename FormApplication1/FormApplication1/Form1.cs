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

        string name;
        string surname;
        DateTime birthday;
        string country;
        string gender;
        string studentOr;

        private void sendButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); 
            progressBar1.Value = 10;
            name=nameTextBox.Text;
            surname=surnameTextBox.Text;
            birthday=dateTimePicker1.Value;
            country=countryComboBox.SelectedText;
            if (male.Checked)
            {
                gender="Male";

            }else
            {
                gender="Female";
            }
            if (yes.Checked) {
                studentOr="Yes";

            }
            else
            {
                studentOr="No";
            }
            
            //atanan degerleri ekleme 
            listBox1.Items.Add(name);
            listBox1.Items.Add(surname);
            listBox1.Items.Add(birthday);
            listBox1.Items.Add(gender);
            listBox1.Items.Add(studentOr);
            listBox1.Items.Add(country);

            /*
            nameTextBox.Text="";
            surnameTextBox.Text="";
            male.Checked=false;
            female.Checked=false;
            yes.Checked=false;
            no.Checked=false;
            */
                
                
            progressBar1.Value = 100;


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
