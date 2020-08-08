using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Ticket_booking
{
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void Label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new_releases f = new new_releases();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\pec_website\Ticket_booking\Login.mdf;Integrated Security=True");
            string query="Select * from Details where Username ='"+txtUsername.Text.Trim()+"'and password = '"+txtpassword.Text.Trim()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if(dtbl.Rows.Count==1)
            {
                MessageBox.Show("Login Successfull");
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Check your Username and password");

            }
        }

        private void Txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {
            sign_up f = new sign_up();
            f.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = '*';
        }
    }
}
