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
        void ShowListView()
        {
            listView1.Items.Clear();
            foreach (AdvertisingСompany advertisingСomp in Program.sinDB.AdvertisingСompany)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        advertisingСomp.Id.ToString(), 
                        advertisingСomp.IdType.ToString() + ". " + advertisingСomp.TypeAdv.Type,
                        advertisingСomp.IdClients.ToString() + ". " + advertisingСomp.Clients.Websait,
                        advertisingСomp.IdStatus.ToString() + ". " + advertisingСomp.StatusAdv.Status,
                        advertisingСomp.IdStrategy.ToString() + ". " + advertisingСomp.StrategyAdv.Strategy,
                        //advertisingСomp.IdBudget.ToString() + ". " + advertisingСomp.BudgetAdv.Budget,
                        advertisingСomp.IdPlace.ToString() + ". " + advertisingСomp.PlaceForAdv.PlaceForAdv1
                    });
                item.Tag = advertisingСomp;
                listView1.Items.Add(item);
            }
        }
        public FormAdvertisingCamp()
        {
            InitializeComponent();
            if (Coloring.Back == 1) this.BackColor = Color.Black;
            if (Coloring.Back == 2) this.BackColor = Color.FromArgb(64, 64, 64);
            if (Coloring.Back == 3) this.BackColor = Color.White;
            ShowComboboxUserWeb();
            ShowListView();
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

        private void FormAdvertisingCamp_Load(object sender, EventArgs e)
        {

        }
    }
}
