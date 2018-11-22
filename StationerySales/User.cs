using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerySales
{
    class User
    {
        public bool valid;
        public static string user = "admin";
        public static string pw = "123456";
        public string Username { get; set; }
        public string Password { get; set; }

        public User(string userNM, string passW)
        {
            Username = userNM;
            Password = passW;

            if (Username.Equals(user) && Password.Equals(pw))
                valid = true;
            else
                valid = false;
        }
    }
}
