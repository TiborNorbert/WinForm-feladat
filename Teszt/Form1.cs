using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teszt
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Nevtext.Text))
            {
                MessageBox.Show("Nem adott meg az informáiót Név", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Azonnum == null)
            {
                MessageBox.Show("Nem adott meg az informásiót Azonositó", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(szuletetthely.Text))
            {
                MessageBox.Show("Nem adott meg az informásiót Szuletési hely", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!angol.Checked && !olasz.Checked && !nemet.Checked && !francia.Checked)
            {
                MessageBox.Show("Nem adott meg az informásiót Nyelv", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Helyesen megadta az adatokat");
            }
        }
    }
}
