using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinaptik
{
    public partial class FormPay : Form
    {
        public void ShowListView()
        {
            listView1.Items.Clear();
            foreach (AdvertisingСompany advСomp in Program.sinDB.AdvertisingСompany)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        advСomp.Id.ToString(),
                        advСomp.Clients.Websait,
                        advСomp.Consumption.ToString(),
                        advСomp.Clients.Surname + " " + advСomp.Clients.Name,
                        advСomp.Budget.ToString()
                    });
                item.Tag = advСomp;
                listView1.Items.Add(item);
            }
        }
        public FormPay()
        {
            InitializeComponent();
            ShowListView();
            if (Coloring.Back == 1) this.BackColor = Color.Black;
            if (Coloring.Back == 2) this.BackColor = Color.FromArgb(64, 64, 64);
            if (Coloring.Back == 3) this.BackColor = Color.White;
        }
        void FormPay_FormClosed(object sender, FormClosedEventArgs e)
        {
            Back();
        }
        void buttonSettings_Click(object sender, EventArgs e)
        {
            Back();
        }
        public void Back()
        {
            Form menu = new FormMenu();
            this.Hide();
            menu.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                button1.Visible = true;
                AdvertisingСompany advСompany = listView1.SelectedItems[0].Tag as AdvertisingСompany;
                textBox1.Text = advСompany.Consumption.ToString();
                textBox2.Text = advСompany.Budget.ToString();
                textBox3.Text = (advСompany.Consumption - advСompany.Budget).ToString();
            }
            else
            {
                button1.Visible = false;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                labelName.Text = "Номер банковской карты:";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                labelName.Text = "Номер счета:";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                labelName.Text = "Номер PayPal:";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                panel2.Visible = true;
            }
            else
            {
                panel2.Visible = false;
            }
        }
    }
}