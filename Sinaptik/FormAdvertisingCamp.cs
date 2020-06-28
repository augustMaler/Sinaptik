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
            if(Personal.System == 1)
            {
                ListViewCheck(1, Personal.Id);
            }
            if (Personal.System == 2)
            {
                ListViewCheck(2, Personal.Id);
            }
            if (Personal.System == 3)
            {
                ListViewCheck(3, Personal.Id);
            }
        }
        public void ListViewCheck(int i, int id)
        {
            listView1.Items.Clear();
            foreach (AdvertisingСompany advСomp in Program.sinDB.AdvertisingСompany)
            {
                if (advСomp.IdAdvComp == i & advСomp.IdClients == id)
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
        }
        public FormAdvertisingCamp()
        {
            InitializeComponent();
            if (Coloring.Back == 1) this.BackColor = Color.Black;
            if (Coloring.Back == 2) this.BackColor = Color.FromArgb(64, 64, 64);
            if (Coloring.Back == 3) this.BackColor = Color.White;
            ShowListView();
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
            if (Personal.System == 1)
            {
                AddItem(1);
            }
            if (Personal.System == 2)
            {
                AddItem(2);
            }
            if (Personal.System == 3)
            {
                AddItem(3);
            }
        }
        public void AddItem(int i)
        {
            AdvertisingСompany advertisingСomp = new AdvertisingСompany();
            advertisingСomp.IdType = Convert.ToInt32(comboBoxType.SelectedItem.ToString().Split('.')[0]);
            advertisingСomp.IdClients = Personal.Id;
            advertisingСomp.IdStatus = Convert.ToInt32(comboBoxStatus.SelectedItem.ToString().Split('.')[0]);
            advertisingСomp.IdStrategy = Convert.ToInt32(comboBoxStrategy.SelectedItem.ToString().Split('.')[0]);
            advertisingСomp.IdPlace = Convert.ToInt32(comboBoxPlace.SelectedItem.ToString().Split('.')[0]);
            advertisingСomp.Consumption = Convert.ToInt32(textBox1.Text);
            advertisingСomp.Budget = 0;
            advertisingСomp.IdAdvComp = i;
            Program.sinDB.AdvertisingСompany.Add(advertisingСomp);
            Program.sinDB.SaveChanges();
            ShowListView();
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
        private void FormAdvertisingCamp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}