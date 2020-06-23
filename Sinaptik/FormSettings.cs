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
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
            if (Coloring.Back == 1) this.BackColor = Color.Black;
            if (Coloring.Back == 2) this.BackColor = Color.FromArgb(64, 64, 64);
            if (Coloring.Back == 3) this.BackColor = Color.White;
        }
        void FormSettings_FormClosed(object sender, FormClosedEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex.ToString() == "0")
            {
                Coloring.Back = 1;
            }
            if (comboBox2.SelectedIndex.ToString() == "1")
            {
                Coloring.Back = 2;
            }
            if (comboBox2.SelectedIndex.ToString() == "2")
            {
                Coloring.Back = 3;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex.ToString() == "0")
            {
                Author.Name = 1;
            }
            if (comboBox1.SelectedIndex.ToString() == "1")
            {
                Author.Name = 2;
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex.ToString() == "0")
            {
                label2.BackColor = Color.Black;
            }
            if (comboBox2.SelectedIndex.ToString() == "1")
            {
                label2.BackColor = Color.FromArgb(64, 64, 64);
            }
            if (comboBox2.SelectedIndex.ToString() == "2")
            {
                label2.BackColor = Color.White;
            }
        }
    }
}
