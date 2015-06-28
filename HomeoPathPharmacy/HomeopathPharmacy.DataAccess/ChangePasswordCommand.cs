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
    public class ChangePasswordCommand
    {
        LogInInfo GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            LogInInfo ob = new LogInInfo();
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
        public LogInInfo GetUserName(String name)
        {
            HomeoPathFramework db = new HomeoPathFramework();
            SqlCommand cmd = db.GetCommand("select * from User_Doctor where User_Name like '%" + name + "%'");
            LogInInfo ob = GetData(cmd);
            return ob;
        }
        public bool ChangePassword(string name, string password)
        {
            HomeoPathFramework da = new HomeoPathFramework();
            SqlCommand cmd = da.GetCommand("update [dbo].[User_Doctor] set User_Password=@password where User_Name=@name");
            SqlParameter p = new SqlParameter("@password", SqlDbType.VarChar, 50);
            p.Value = password;
            SqlParameter p1 = new SqlParameter("@name", SqlDbType.VarChar, 50);
            p1.Value = name; ;
            cmd.Parameters.Add(p);
            cmd.Parameters.Add(p1);
            cmd.Connection.Open();
            int val = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return val > 0;
        }
    }
}
