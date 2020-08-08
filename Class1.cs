using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ticket_booking
{
    class Class1
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public string locate = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\pec_website\Ticket_booking\Login.mdf;Integrated Security=True";


    }
}
