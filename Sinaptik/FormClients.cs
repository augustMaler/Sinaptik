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
    public partial class FormClients : Form
    {
        void ShowClient()
        {
            listView1.Items.Clear();
            foreach (Clients clients in Program.sinDB.Clients)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        clients.id.ToString(), clients.name, clients.surname,
                        clients.email, clients.phone, clients.websait
                    });
                item.Tag = clients;
                listView1.Items.Add(item);
            }
        }
        public FormClients()
        {
            InitializeComponent();
            if (Coloring.Back == 1) this.BackColor = Color.Black;
            if (Coloring.Back == 2) this.BackColor = Color.FromArgb(64, 64, 64);
            if (Coloring.Back == 3) this.BackColor = Color.White;
            ShowClient();
        }

        void FormClients_FormClosed(object sender, FormClosedEventArgs e)
        {
            Back();
        }

        void buttonSettings_Click(object sender, EventArgs e)
        {
            Back();
        }
        public void Back()
        {
            Form Menu = Application.OpenForms[0];
            Menu.StartPosition = FormStartPosition.Manual;
            Menu.Left = this.Left;
            Menu.Top = this.Top;
            this.Hide();
            Menu.Show();
        }
        void button3_Click(object sender, EventArgs e)
        {
            Clients client = new Clients();
            client.name = textBox1.Text;
            client.surname = textBox2.Text;
            client.email = textBox3.Text;
            client.phone = textBox4.Text;
            client.websait = textBox5.Text;
            if (textBox3.Text.Contains("@") == true && textBox3.Text.Contains(".") == true)
            {
                client.email = textBox3.Text;
                Program.sinDB.Clients.Add(client);
                Program.sinDB.SaveChanges();
                ShowClient();
            }
            else
            {
                label7.Text = "Вы не правильно указали почту!";
            }
        }

        void textBox3_TextChanged(object sender, EventArgs e)
        {
            label7.Text = "";
        }

        void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                Clients client = listView1.SelectedItems[0].Tag as Clients;
                client.name = textBox1.Text;
                client.surname = textBox2.Text;
                client.email = textBox3.Text;
                client.phone = textBox4.Text;
                client.websait = textBox5.Text;
                Program.sinDB.SaveChanges();
                ShowClient();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count == 1)
                {
                    Clients client = listView1.SelectedItems[0].Tag as Clients;
                    Program.sinDB.Clients.Remove(client);
                    Program.sinDB.SaveChanges();
                    ShowClient();
                }
                else
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                Clients client = listView1.SelectedItems[0].Tag as Clients;
                textBox1.Text = client.name;
                textBox2.Text = client.surname;
                textBox3.Text = client.email;
                textBox4.Text = client.phone;
                textBox5.Text = client.websait;
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
        }
    }
}