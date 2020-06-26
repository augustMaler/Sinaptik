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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        void buttonClients_Click(object sender, EventArgs e)
        {
            Form Clients = new FormClients();
            Clients.Left = this.Left;
            Clients.Top = this.Top;
            Clients.Show();
            this.Hide();
        }
        void buttonPay_Click(object sender, EventArgs e)
        {
            Form Pay = new FormPay();
            Pay.Left = this.Left;
            Pay.Top = this.Top;
            Pay.Show();
            this.Hide();
        }
        void buttonDayRes_Click(object sender, EventArgs e)
        {
            Form DayResult = new FormDayResult();
            DayResult.Left = this.Left;
            DayResult.Top = this.Top;
            DayResult.Show();
            this.Hide();
        }
        void buttonSettings_Click(object sender, EventArgs e)
        {
            Form Settings = new FormSettings();
            Settings.Left = this.Left;
            Settings.Top = this.Top;
            Settings.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Author.Name == 1) labelby.Text = "Разработано ООО \"Синаптик\"";
            if (Author.Name == 2) labelby.Text = "Разработано Страшко Артемием";
            if (Coloring.Back == 1) this.BackColor = Color.Black;
            if (Coloring.Back == 2) this.BackColor = Color.FromArgb(64, 64, 64);
            if (Coloring.Back == 3) this.BackColor = Color.White;
        }
    }
}
