using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HotelReservation.Model
{
    public class dbReservation
    {
        String dbinfo = "server=localhost;userid=root;database=hotelres";
        private MySqlConnection cnx = null;
        public dbReservation()
        {
            try
            {
                cnx = new MySqlConnection(dbinfo);
            }
            catch(MySqlException E)
            {
                Console.WriteLine("Error : {0}", E.ToString());
            }
        }
    }
}