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
        public void ShowListView()
        {
            listView1.Items.Clear();
            foreach (AdvertisingСompany advСomp in Program.sinDB.AdvertisingСompany)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        advСomp.Id.ToString(),
                        advСomp.IdType.ToString(),
                        advСomp.IdClients.ToString(),
                        advСomp.IdStatus.ToString(),
                        advСomp.IdStrategy.ToString(),
                        advСomp.IdPlace.ToString(),
                        advСomp.Consumption.ToString()
                    });
                item.Tag = advСomp;
                listView1.Items.Add(item);
            }
        }

        public FormAdvertisingCamp()
        {
            InitializeComponent();
            if (Coloring.Back == 1) this.BackColor = Color.Black;
            if (Coloring.Back == 2) this.BackColor = Color.FromArgb(64, 64, 64);
            if (Coloring.Back == 3) this.BackColor = Color.White;
            if (Personal.System == 1) label1.Text = "Google";
            if (Personal.System == 2) label1.Text = "Yandex";
            if (Personal.System == 3) label1.Text = "VK";
            ShowComboboxUserWeb();
            ShowComboboxType();
            ShowComboboxStatus();
            ShowComboboxStrategy();
            ShowComboboxPlace();
        }
        void ShowComboboxType()
        {
            comboBoxType.Items.Clear();
            foreach (TypeAdv type in Program.sinDB.TypeAdv)
            {
                string[] item = { type.Type };
                comboBoxType.Items.Add(string.Join(" ", item));
            }
        }
        void ShowComboboxUserWeb()
        {
            comboBoxUserWeb.Items.Clear();
            foreach (Clients web in Program.sinDB.Clients)
            {
                string[] item = { web.Websait };
                comboBoxUserWeb.Items.Add(string.Join(" ", item));
            }
        }
        void ShowComboboxStatus()
        {
            comboBoxStatus.Items.Clear();
            foreach (StatusAdv status in Program.sinDB.StatusAdv)
            {
                string[] item = { status.Status };
                comboBoxStatus.Items.Add(string.Join(" ", item));
            }
        }
        void ShowComboboxStrategy()
        {
            comboBoxStrategy.Items.Clear();
            foreach (StrategyAdv strategy in Program.sinDB.StrategyAdv)
            {
                string[] item = { strategy.Strategy };
                comboBoxStrategy.Items.Add(string.Join(" ", item));
            }
        }
        void ShowComboboxPlace()
        {
            comboBoxPlace.Items.Clear();
            foreach (PlaceForAdv place in Program.sinDB.PlaceForAdv)
            {
                string[] item = { place.PlaceForAdv1 };
                comboBoxPlace.Items.Add(string.Join(" ", item));
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num) && num != 8 || num == 127)
            {
                e.Handled = true;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AdvertisingСompany advertisingСomp = new AdvertisingСompany();

            advertisingСomp.Consumption = Convert.ToInt32(textBox1.Text);
            Program.sinDB.AdvertisingСompany.Add(advertisingСomp);
            Program.sinDB.SaveChanges();
            ShowListView();
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
    }
}
