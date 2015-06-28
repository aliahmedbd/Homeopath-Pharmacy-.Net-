using HomeoPathPhamacy.Entity;
using HomeoPathPharmacy.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeopathPharmacy.DataAccess
{
    
        public class LogInCommand
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
        }
    }

