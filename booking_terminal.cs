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
    public partial class booking_terminal : Form
    {
        public booking_terminal()
        {
            InitializeComponent();
        }
       
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\pec_website\Ticket_booking\Login.mdf;Integrated Security=True");



        private void LOGIN_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "" && comboBox4.Text != "")
            {

                con.Open();
                String query = " INSERT INTO Book (movie,date,theatre,time) VALUES('" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "')";

                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data inserted successfully");
            }
            else
            {
                MessageBox.Show("Fill the Credentials");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "" && comboBox4.Text != "")
            {

                con.Open();
                String query = "SELECT  * FROM Book ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Fill the Credentials");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "" && comboBox4.Text != "")
            {

                con.Open();
                String query = " DELETE FROM  Book WHERE movie='" + comboBox1.Text + "'";

                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data deleted successfully");
            }
            else
            {
                MessageBox.Show("Fill the Credentials");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "" && comboBox4.Text != "")
            {

                con.Open();
                String query = " UPDATE  Book SET movie='" + comboBox2.Text + "' WHERE movie ='" + comboBox1.Text + "'";

                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data updated successfully");
            }
            else
            {
                MessageBox.Show("Fill the Credentials");
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "" && comboBox4.Text != "")
            {

                BILL d = new BILL();
                d.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Fill the Credentials");
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
