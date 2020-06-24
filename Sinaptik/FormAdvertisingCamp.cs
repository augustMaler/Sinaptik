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
    public partial class FormAdvertisingCamp : Form
    {
        public FormAdvertisingCamp()
        {
            InitializeComponent();
            if (Coloring.Back == 1) this.BackColor = Color.Black;
            if (Coloring.Back == 2) this.BackColor = Color.FromArgb(64, 64, 64);
            if (Coloring.Back == 3) this.BackColor = Color.White;
        }

        void FormAdvertisingCamp_FormClosed(object sender, FormClosedEventArgs e)
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
        private void FormAdvertisingCamp_Load(object sender, EventArgs e)
        {
            if (AdvSys.Sys == 1) label2.Text = "Google";
            if (AdvSys.Sys == 2) label2.Text = "Yandex";
            if (AdvSys.Sys == 3) label2.Text = "VK";
        }
    }
}
