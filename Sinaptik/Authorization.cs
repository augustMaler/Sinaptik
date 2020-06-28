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
    public partial class Authorization : Form
    {
        public bool checkText = true;
        public Authorization()
        {
            InitializeComponent();
        }
        private void buttonClients_Click(object sender, EventArgs e)
        {
            FormMenu Menu = new FormMenu();
            Menu.StartPosition = FormStartPosition.Manual;
            Menu.Left = this.Left;
            Menu.Top = this.Top;
            this.Hide();
            Menu.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool chechPassword = false;
            if (textBox1.Text == "" & textBox2.Text == "")
            {
                MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK);
            }
            else
            {
                foreach (Autorization author in Program.sinDB.Autorization)
                {
                    if (textBox1.Text == author.Login & textBox2.Text == author.Password) chechPassword = true;
                }
            }
            if (chechPassword)
            {
                FormMenu Menu = new FormMenu();
                textBox1.Text = "";
                textBox2.Text = "";
                this.Hide();
                Menu.Show();
            }
            else
            {
                MessageBox.Show("Данные введены неверно", "Ошибка", MessageBoxButtons.OK);
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (checkText)
            {
                textBox2.Enabled = false;
                textBox2.Visible = false;
                button2.Text = "Пароль\nВидно";
                checkText = false;
            }
            else if (!checkText)
            {
                textBox2.Enabled = true;
                textBox2.Visible = true;
                button2.Text = "Пароль\nНе видно";
                checkText = true;
            }
        }
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            textBox3.Text = textBox2.Text;
        }
    }
}
