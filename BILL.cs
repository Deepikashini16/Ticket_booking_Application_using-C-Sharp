using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket_booking
{
    public partial class BILL : Form
    {
        public BILL()
        {
            InitializeComponent();
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text!=""&&textBox5.Text!=""&&textBox6.Text!=""&&txtUsername.Text!="")
            {
                groupBox1.Visible = true;
                button1.Visible = true;
                String constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\pec_website\Ticket_booking\Login.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(constring);
                SqlCommand sc;
                SqlDataReader rd;
                String sql = "Select * from Book";
                try
                {
                    con.Open();
                   // MessageBox.Show("connection is active");
                    sc = new SqlCommand(sql, con);
                    rd = sc.ExecuteReader();
                    while(rd.Read())
                    {
                        textBox15.Text = rd.GetValue(0).ToString();
                        textBox8.Text = rd.GetValue(3).ToString();
                        textBox9.Text = comboBox1.Text;
                        int i = int.Parse(comboBox1.Text);
                        i = i * 150;
                        textBox10.Text = i.ToString();


                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
            else
            {
                MessageBox.Show("Fill the Credentials");
            }
        }

        private void TextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            end c = new end();
            c.Show();
            this.Hide();
        }

        private void BILL_Load(object sender, EventArgs e)
        {

        }
    }
}

