﻿using System;
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
    public partial class Fast_and_furious : Form
    {
        public Fast_and_furious()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            booking_terminal f = new booking_terminal();
            f.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new_releases f = new new_releases();
            f.Show();
            this.Hide();
        }
    }
}
