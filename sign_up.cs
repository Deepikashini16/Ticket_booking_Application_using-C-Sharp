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
    public partial class sign_up : Form
    {
        public sign_up()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtpasswordnew.PasswordChar = '*';
            txtConfirmpassword.PasswordChar = '*';
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {
            Login_form f = new Login_form();
            f.Show();
            this.Hide();
            
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            if(txtUsernamenew.Text!=""&&txtpasswordnew.Text!=""&&txtConfirmpassword.Text!="")
            {
                if (txtConfirmpassword.Text == txtpasswordnew.Text)
                {
                    try
                    {
                        Class1 obj = new Class1();
                        obj.con.ConnectionString = obj.locate;
                        obj.con.Open();
                        string insertuser = "insert into Details values ('" + txtUsernamenew.Text + "','" + txtConfirmpassword.Text + "')";
                        obj.cmd.Connection = obj.con;
                        obj.cmd.CommandText = insertuser;
                        obj.cmd.ExecuteNonQuery();
                        obj.con.Close();
                        MessageBox.Show("User signUp has been Completed");
                        Login_form f = new Login_form();
                        f.Show();
                        this.Hide();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }
                }
                else
                {
                    MessageBox.Show("Password Does not match");
                }
              }
           else
            {
                MessageBox.Show("Enter valid username or password");

            }

        }
    }
}
