using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

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
                        advСomp.TypeAdv.Type,
                        advСomp.Clients.Surname + " " + advСomp.Clients.Name,
                        advСomp.Clients.Websait,
                        advСomp.StatusAdv.Status,
                        advСomp.StrategyAdv.Strategy,
                        advСomp.PlaceForAdv.PlaceForAdv1,
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
            ShowListView();
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
                string[] item = { type.Id + ".", type.Type };
                comboBoxType.Items.Add(string.Join(" ", item));
            }
        }
        void ShowComboboxUserWeb()
        {
            comboBoxUserWeb.Items.Clear();
            foreach (Clients web in Program.sinDB.Clients)
            {
                string[] item = { web.Id + ". ", web.Websait };
                comboBoxUserWeb.Items.Add(string.Join(" ", item));
            }
        }
        void ShowComboboxStatus()
        {
            comboBoxStatus.Items.Clear();
            foreach (StatusAdv status in Program.sinDB.StatusAdv)
            {
                string[] item = { status.Id + ". ", status.Status };
                comboBoxStatus.Items.Add(string.Join(" ", item));
            }
        }
        void ShowComboboxStrategy()
        {
            comboBoxStrategy.Items.Clear();
            foreach (StrategyAdv strategy in Program.sinDB.StrategyAdv)
            {
                string[] item = { strategy.Id + ". ", strategy.Strategy };
                comboBoxStrategy.Items.Add(string.Join(" ", item));
            }
        }
        void ShowComboboxPlace()
        {
            comboBoxPlace.Items.Clear();
            foreach (PlaceForAdv place in Program.sinDB.PlaceForAdv)
            {
                string[] item = {place.Id + ". ", place.PlaceForAdv1 };
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
            try
            {
                if (listView1.SelectedItems.Count == 1)
                {
                    AdvertisingСompany advCamp = listView1.SelectedItems[0].Tag as AdvertisingСompany;
                    Program.sinDB.AdvertisingСompany.Remove(advCamp);
                    Program.sinDB.SaveChanges();
                    ShowListView();
                }
                else
                {
                    textBox1.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AdvertisingСompany advertisingСomp = new AdvertisingСompany();
            advertisingСomp.IdType = Convert.ToInt32(comboBoxType.SelectedItem.ToString().Split('.')[0]);
            advertisingСomp.IdClients = Convert.ToInt32(comboBoxUserWeb.SelectedItem.ToString().Split('.')[0]);
            advertisingСomp.IdStatus = Convert.ToInt32(comboBoxStatus.SelectedItem.ToString().Split('.')[0]);
            advertisingСomp.IdStrategy = Convert.ToInt32(comboBoxStrategy.SelectedItem.ToString().Split('.')[0]);
            advertisingСomp.IdPlace = Convert.ToInt32(comboBoxPlace.SelectedItem.ToString().Split('.')[0]);
            advertisingСomp.Consumption = Convert.ToInt32(textBox1.Text);
            advertisingСomp.Budget = 0;
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
            FormMenu Menu = new FormMenu();
            this.Hide();
            Menu.Show();
        }
    }
}