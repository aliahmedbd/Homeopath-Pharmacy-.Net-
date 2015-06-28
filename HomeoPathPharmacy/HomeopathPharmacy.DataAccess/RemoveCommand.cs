using HomeoPathPhamacy.Entity;
using HomeoPathPharmacy.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeopathPharmacy.DataAccess
{
    public class RemoveCommand
    {
        public bool RemovePatient(int id)
        {
            HomeoPathFramework ob = new HomeoPathFramework();
            SqlCommand cmd = ob.GetCommand("delete from  [dbo].[Patient_Medicine] where Patient_Id=@Id");
            SqlParameter p = new SqlParameter(@"Id", SqlDbType.Int);
            p.Value = id;
            cmd.Parameters.Add(p);
            cmd.Connection.Open();
            int val = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return val > 0;
            

        }

    }
}
