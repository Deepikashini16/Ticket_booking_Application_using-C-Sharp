using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket_booking
{
    public partial class new_releases : Form
    {
        public new_releases()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Abominable a = new Abominable();
            a.Show();
            this.Hide();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            ALADINcs a = new ALADINcs();
            a.Show();
            this.Hide();

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            charlie c = new charlie();
            c.Show();
            this.Hide();
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            Fast_and_furious f = new Fast_and_furious();
            f.Show();
            this.Hide();

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            joker j = new joker();
            j.Show();
            this.Hide();

        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            DORA d = new DORA();
            d.Show();
            this.Hide();
        }
    }
}
