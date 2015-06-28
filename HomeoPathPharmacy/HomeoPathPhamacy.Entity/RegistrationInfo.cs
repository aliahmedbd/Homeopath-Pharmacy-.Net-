using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeoPathPhamacy.Entity
{
    public class RegistrationInfo
    {
        public int id;
        private string userName;
        private string password;
        public string UserName { get { return userName; } set { userName = value; } }
        public string Password { get { return password; } set { password = value; } }
        public int Id { get { return id; } set { id = value; } }
    }
}
