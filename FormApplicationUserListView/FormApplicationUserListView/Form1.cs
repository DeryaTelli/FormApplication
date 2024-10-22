using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApplicationUserListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string customerId, phoneNum;
            string name, surname, job;
            customerId=idTextB.Text;
            phoneNum=phoneTextB.Text;
            name=nameTextB.Text;
            surname=surnameTextB.Text;
            job =jobTextB.Text;

            string[] list = { customerId, name, surname, phoneNum, job };
            ListViewItem items = new ListViewItem(list);
            listView1.Items.Add(items);
            idTextB.Text = "";
            phoneTextB.Text="";
            nameTextB.Text="";
            surnameTextB.Text="";
            jobTextB.Text="";
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count>0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);

            }
            else
            {
                MessageBox.Show("Please , select the item");
            }
        }
    }
}
