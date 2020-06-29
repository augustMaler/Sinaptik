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
    public partial class FormDayResult : Form
    {
        public bool checkTimer = true;
        void ShowComboboxClients()
        {
            comboBox1.Items.Clear();
            foreach (Clients clients in Program.sinDB.Clients)
            {
                string[] item = { clients.Surname, " " + clients.Name };
                comboBox1.Items.Add(string.Join(" ", item));
            }
        }
        public FormDayResult()
        {
            InitializeComponent();
            ShowComboboxClients();
            if (Coloring.Back == 1) this.BackColor = Color.Black;
            if (Coloring.Back == 2) this.BackColor = Color.FromArgb(64, 64, 64);
            if (Coloring.Back == 3) this.BackColor = Color.White;
        }
        void FormDayResult_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        void buttonSettings_Click(object sender, EventArgs e)
        {
            Back();
        }
        public void Back()
        {
            FormMenu Menu = new FormMenu();
            this.Hide();
            Menu.Show();
        }
        public int time;
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkTimer)
            {
                labelCheck.Text = "Проверка подключения";
                time = 5;
                checkTimer = false;
                timer1.Enabled = true;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(time >= 1)
            {
                time--;
            }
            else
            {
                labelCheck.Text = "Отсутствует подключение к интернету";
                timer1.Enabled = false;
                checkTimer = true;
            }
        }
    }
}
