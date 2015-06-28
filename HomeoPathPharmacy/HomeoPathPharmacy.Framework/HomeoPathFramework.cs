using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeoPathPharmacy.Framework
{
    public class HomeoPathFramework
    {
        const string connectingString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Ali Ahmed\documents\visual studio 2012\Projects\HomeoPathPharmacy\HomeoPathPharmacy\Database1.mdf;Integrated Security=True";
        public SqlCommand GetCommand(string query)
        {
            var connection = new SqlConnection(connectingString);
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection=connection;
            return cmd;

        }
    }
}
