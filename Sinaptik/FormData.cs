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
    public partial class FormData : Form
    {
        public void ShowListsType()
        {
            listView1.Items.Clear();
            foreach (TypeAdv typeAdv in Program.sinDB.TypeAdv)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        typeAdv.Id.ToString(), typeAdv.Type
                    });
                item.Tag = typeAdv;
                listView1.Items.Add(item);
            }
        }
        public void ShowListsStatus()
        {
            listView2.Items.Clear();
            foreach (StatusAdv statusAdv in Program.sinDB.StatusAdv)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        statusAdv.Id.ToString(), statusAdv.Status
                    });
                item.Tag = statusAdv;
                listView2.Items.Add(item);
            }
        }
        public void ShowListsStrategy()
        {
            listView3.Items.Clear();
            foreach (StrategyAdv strategyAdv in Program.sinDB.StrategyAdv)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        strategyAdv.Id.ToString(), strategyAdv.Strategy
                    });
                item.Tag = strategyAdv;
                listView3.Items.Add(item);
            }
        }
        public void ShowListsPlace()
        {
            listView4.Items.Clear();
            foreach (PlaceForAdv placeForAdv in Program.sinDB.PlaceForAdv)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        placeForAdv.Id.ToString(), placeForAdv.PlaceForAdv1
                    });
                item.Tag = placeForAdv;
                listView4.Items.Add(item);
            }
        }
        public FormData()
        {
            InitializeComponent();
            ShowListsStrategy();
            ShowListsType();
            ShowListsStatus();
            ShowListsPlace();
            if (Coloring.Back == 1) this.BackColor = Color.Black;
            if (Coloring.Back == 2) this.BackColor = Color.FromArgb(64, 64, 64);
            if (Coloring.Back == 3) this.BackColor = Color.White;
        }

        void buttonSettings_Click(object sender, EventArgs e)
        {
            Back();
        }
        private void FormData_FormClosed(object sender, FormClosedEventArgs e)
        {
            Back();
        }
        public void Back()
        {
            Form Adv = new FormAdvertising();
            Adv.StartPosition = FormStartPosition.Manual;
            Adv.Left = this.Left;
            Adv.Top = this.Top;
            this.Hide();
            Adv.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TypeAdv typeAdv = new TypeAdv();
            typeAdv.Type = textBox1.Text;
            Program.sinDB.TypeAdv.Add(typeAdv);
            Program.sinDB.SaveChanges();
            ShowListsType();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count == 1)
                {
                    TypeAdv typeAdv = listView1.SelectedItems[0].Tag as TypeAdv;
                    Program.sinDB.TypeAdv.Remove(typeAdv);
                    Program.sinDB.SaveChanges();
                    ShowListsType();
                    textBox2.Text = "";
                }
                else
                {
                    textBox2.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StatusAdv statusAdv = new StatusAdv();
            statusAdv.Status = textBox2.Text;
            Program.sinDB.StatusAdv.Add(statusAdv);
            Program.sinDB.SaveChanges();
            ShowListsStatus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView2.SelectedItems.Count == 1)
                {
                    StatusAdv statusAdv = listView1.SelectedItems[0].Tag as StatusAdv;
                    Program.sinDB.StatusAdv.Remove(statusAdv);
                    Program.sinDB.SaveChanges();
                    ShowListsStatus();
                    textBox2.Text = "";
                }
                else
                {
                    textBox2.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            StrategyAdv strategyAdv = new StrategyAdv();
            strategyAdv.Strategy = textBox3.Text;
            Program.sinDB.StrategyAdv.Add(strategyAdv);
            Program.sinDB.SaveChanges();
            ShowListsStrategy();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView3.SelectedItems.Count == 1)
                {
                    StrategyAdv strategyAdv = listView3.SelectedItems[0].Tag as StrategyAdv;
                    Program.sinDB.StrategyAdv.Remove(strategyAdv);
                    Program.sinDB.SaveChanges();
                    ShowListsStrategy();
                    textBox3.Text = "";
                }
                else
                {
                    textBox3.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PlaceForAdv placeForAdv = new PlaceForAdv();
            placeForAdv.PlaceForAdv1 = textBox4.Text;
            Program.sinDB.PlaceForAdv.Add(placeForAdv);
            Program.sinDB.SaveChanges();
            ShowListsPlace();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView4.SelectedItems.Count == 1)
                {
                    PlaceForAdv placeForAdv = listView4.SelectedItems[0].Tag as PlaceForAdv;
                    Program.sinDB.PlaceForAdv.Remove(placeForAdv);
                    Program.sinDB.SaveChanges();
                    ShowListsPlace();
                    textBox4.Text = "";
                }
                else
                {
                    textBox4.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
