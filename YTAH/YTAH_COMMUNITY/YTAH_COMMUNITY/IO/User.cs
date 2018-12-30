using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTAH_COMMUNITY.IO
{
    public class User
    {
        public static List<User> users = new List<User>();
        public string username;
        public string poste;
        public string admin;
        public string ip;
        public User(string usernames, string postes, string isadmin, string ipadress)
        {
            username = usernames;
            poste = postes;
            admin = isadmin;
            ip = ipadress;
        }
    }
}
