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
    public partial class front : Form
    {
        public front()
        {
            InitializeComponent();

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        public void Wait(int time)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Login_form f = new Login_form();
            f.Show();
            this.Hide();
        }
    }
    }

