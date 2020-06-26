using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Sinaptik
{
    public partial class FormAdvertising : Form
    {
        public FormAdvertising()
        {
            InitializeComponent();
            label4.Text = $"Id Пользователя: {Personal.Id}" +
                $"\nИмя: {Personal.Name} {Personal.Surname}";
            if (Coloring.Back == 1) this.BackColor = Color.Black;
            if (Coloring.Back == 2) this.BackColor = Color.FromArgb(64, 64, 64);
            if (Coloring.Back == 3) this.BackColor = Color.White;
            if (AdvSys.Google == 1) button1.Enabled = false;
            if (AdvSys.Yandex == 1) button2.Enabled = false;
            if (AdvSys.VK == 1) button3.Enabled = false;
            if (AdvSys.Google == 0) button1.Enabled = true;
            if (AdvSys.Yandex == 0) button2.Enabled = true;
            if (AdvSys.VK == 0) button3.Enabled = true;
        }
        void FormAdvertising_FormClosed(object sender, FormClosedEventArgs e)
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
        void buttonClient_Click(object sender, EventArgs e)
        {
            Form Clients = new FormClients();
            Clients.StartPosition = FormStartPosition.Manual;
            Clients.Left = this.Left;
            Clients.Top = this.Top;
            this.Hide();
            Clients.Show();
        }
        void button1_Click(object sender, EventArgs e)
        {
            Personal.System = 1;
            Form AdvCamp = new FormAdvertisingCamp();
            AdvCamp.StartPosition = FormStartPosition.Manual;
            AdvCamp.Left = this.Left;
            AdvCamp.Top = this.Top;
            this.Hide();
            AdvCamp.Show();
        }
        void button2_Click(object sender, EventArgs e)
        {
            Personal.System = 2;
            Form AdvCamp = new FormAdvertisingCamp();
            AdvCamp.StartPosition = FormStartPosition.Manual;
            AdvCamp.Left = this.Left;
            AdvCamp.Top = this.Top;
            this.Hide();
            AdvCamp.Show();
        }
        void button3_Click(object sender, EventArgs e)
        {
            Personal.System = 3;
            Form AdvCamp = new FormAdvertisingCamp();
            AdvCamp.StartPosition = FormStartPosition.Manual;
            AdvCamp.Left = this.Left;
            AdvCamp.Top = this.Top;
            this.Hide();
            AdvCamp.Show();
        }
        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackgroundImage = null;
            button4.Text = "Статистика";
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackgroundImage = null;
            button5.Text = "Статистика";
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.BackgroundImage = null;
            button6.Text = "Статистика";
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.Text = "";
            button4.BackgroundImage = Properties.Resources.Stat;
        }
        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.Text = "";
            button5.BackgroundImage = Properties.Resources.Stat;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.Text = "";
            button6.BackgroundImage = Properties.Resources.Stat;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex.ToString() == "0")
            {
                AdvSys.Google = 0;
                button1.Enabled = true;
            }
            if (comboBox1.SelectedIndex.ToString() == "1")
            {
                AdvSys.Google = 1;
                button1.Enabled = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex.ToString() == "0")
            {
                AdvSys.Yandex = 0;
                button2.Enabled = true;
            }
            if (comboBox2.SelectedIndex.ToString() == "1")
            {
                AdvSys.Yandex = 1;
                button2.Enabled = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex.ToString() == "0")
            {
                AdvSys.VK = 0;
                button3.Enabled = true;
            }
            if (comboBox3.SelectedIndex.ToString() == "1")
            {
                AdvSys.VK = 1;
                button3.Enabled = false;
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            Form Data = new FormData();
            Data.Left = this.Left;
            Data.Top = this.Top;
            Data.Show();
            this.Hide();
        }
    }
}
