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
    public partial class DORA : Form
    {
        public DORA()
        {
            InitializeComponent();
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox15_TextChanged(object sender, EventArgs e)
        {

        }
        private void LOGIN_Click(object sender, EventArgs e)
        {
           
        }


        private void Button1_Click_1(object sender, EventArgs e)
        {
            new_releases f = new new_releases();
            f.Show();
            this.Hide();
        }

        private void LOGIN_Click_1(object sender, EventArgs e)
        {
            booking_terminal f = new booking_terminal();
            f.Show();
            this.Hide();
        }
    }
}
