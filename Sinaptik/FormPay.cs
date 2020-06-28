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
            Application.Exit();
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
                AdvertisingСompany advСompany = listView1.SelectedItems[0].Tag as AdvertisingСompany;
                textBox1.Text = advСompany.Consumption.ToString();
                textBox2.Text = advСompany.Budget.ToString();
                textBox3.Text = (advСompany.Consumption - advСompany.Budget).ToString();
            }
            else
            {

            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                labelName.Text = "Номер банковской карты:";
                textBox5.Visible = true;
                textBox5.Text = "";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                labelName.Text = "Номер счета:";
                textBox5.Visible = true;
                textBox5.Text = "";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                labelName.Text = "Номер PayPal:";
                textBox5.Visible = true;
                textBox5.Text = "";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count == 1)
            {
                if(textBox4.Text != "" & textBox5.Text != "")
                {
                    AdvertisingСompany advComp = listView1.SelectedItems[0].Tag as AdvertisingСompany;
                    advComp.Budget = (advComp.Budget + Convert.ToInt32(textBox4.Text));
                    Program.sinDB.SaveChanges();
                    ShowListView();
                }
                else
                {
                    label9.Text = "Вы не ввели какие-то данные";
                }
            }
            else
            {

            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            label9.Text = "";
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            label9.Text = "";
        }
    }
}