using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QGF.Network.Users
{
    public class User
    {
        public static List<User> users = new List<User>();
        public static string usernem;
        public User(string username, string rank)
        {
            usernem = username;
        }
    }
}
