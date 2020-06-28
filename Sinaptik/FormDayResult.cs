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
    public partial class FormDayResult : Form
    {
        public FormDayResult()
        {
            InitializeComponent();
            if (Coloring.Back == 1) this.BackColor = Color.Black;
            if (Coloring.Back == 2) this.BackColor = Color.FromArgb(64, 64, 64);
            if (Coloring.Back == 3) this.BackColor = Color.White;
        }

        void FormDayResult_FormClosed(object sender, FormClosedEventArgs e)
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
