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
            if (Coloring.Back == 1) this.BackColor = Color.Black;
            if (Coloring.Back == 2) this.BackColor = Color.FromArgb(64, 64, 64);
            if (Coloring.Back == 3) this.BackColor = Color.White;
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
            CheckSys check = new CheckSys();
            if (check.GoogleAct == 1)
            {
                button1.Text = "Google Ads\n(включен)";
                check.GoogleAct = 0;
                Program.sinDB.SaveChanges();
            }
            else if (check.GoogleAct == 0)
            {
                button1.Text = "Google Ads\n(выключен)";
                check.GoogleAct = 1;
                Program.sinDB.SaveChanges();
            }
        }
        void button2_Click(object sender, EventArgs e)
        {
            CheckSys check = new CheckSys();
            if (check.YaAct == 1)
            {
                button2.Text = "Яндекс Директ\n(включен)";
                check.YaAct = 0;
            }
            else if (check.YaAct == 0)
            {
                button2.Text = "Яндекс Директ\n(выключен)";
                check.YaAct = 1;
            }
        }
        void button3_Click(object sender, EventArgs e)
        {
            CheckSys check = new CheckSys();
            if (check.VKAct == 1)
            {
                button3.Text = "Вконтакте Таргетинговая реклама\n(включен)";
                check.VKAct = 0;
            }
            else if (check.VKAct == 0)
            {
                button3.Text = "Вконтакте Таргетинговая реклама\n(выключен)";
                check.VKAct = 1;
            }
        }
    }
}
