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
        public FormData()
        {
            InitializeComponent();
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
    }
}
