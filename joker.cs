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
    public partial class joker : Form
    {
        public joker()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            new_releases f = new new_releases();
            f.Show();
            this.Hide();
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {

            booking_terminal f = new booking_terminal();
            f.Show();
            this.Hide();
        }

        private void Joker_Load(object sender, EventArgs e)
        {

        }
    }
}
