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
            AdvSys.Sys = 1;
            Form AdvCamp = new FormAdvertisingCamp();
            AdvCamp.StartPosition = FormStartPosition.Manual;
            AdvCamp.Left = this.Left;
            AdvCamp.Top = this.Top;
            this.Hide();
            AdvCamp.Show();
        }
        void button2_Click(object sender, EventArgs e)
        {
            AdvSys.Sys = 2;
            Form AdvCamp = new FormAdvertisingCamp();
            AdvCamp.StartPosition = FormStartPosition.Manual;
            AdvCamp.Left = this.Left;
            AdvCamp.Top = this.Top;
            this.Hide();
            AdvCamp.Show();
        }
        void button3_Click(object sender, EventArgs e)
        {
            AdvSys.Sys = 3;
            Form AdvCamp = new FormAdvertisingCamp();
            AdvCamp.StartPosition = FormStartPosition.Manual;
            AdvCamp.Left = this.Left;
            AdvCamp.Top = this.Top;
            this.Hide();
            AdvCamp.Show();
        }
        private void FormAdvertising_Load(object sender, EventArgs e)
        {

        }
    }
}
