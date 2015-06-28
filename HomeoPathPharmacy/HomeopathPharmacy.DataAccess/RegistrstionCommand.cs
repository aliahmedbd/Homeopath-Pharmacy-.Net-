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
    public class RegistrstionCommand
    {
        RegistrationInfo GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            RegistrationInfo ob = new RegistrationInfo();
            using (reader)
            {
                while (reader.Read())
                {
                    ob.Id = reader.GetInt32(0);
                    ob.UserName = reader.GetString(1);
                    ob.Password = reader.GetString(2);
                }
                reader.Close();
            }
            cmd.Connection.Close();
            return ob;
        }
        public RegistrationInfo GetUserName(String name)
        {
            HomeoPathFramework db = new HomeoPathFramework();
            SqlCommand cmd = db.GetCommand("select * from User_Doctor where User_Name like '%" + name + "%'");
            RegistrationInfo ob = GetData(cmd);
            return ob;
        }
        public bool Insert(RegistrationInfo obj)
        {
            HomeoPathFramework da = new HomeoPathFramework();
            SqlCommand cmd = da.GetCommand("insert into [dbo].[User_Doctor] ([User_Name],[User_Password])" + "values(@Name,@Password)");
            SqlParameter p = new SqlParameter("@Name", SqlDbType.VarChar, 50);
            p.Value = obj.UserName;
            SqlParameter p1 = new SqlParameter("@Password", SqlDbType.VarChar, 50);
            p1.Value = obj.Password;
          
            cmd.Parameters.Add(p);
            cmd.Parameters.Add(p1);
            
            cmd.Connection.Open();
            int val = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return val > 0;

        }

    }
}
