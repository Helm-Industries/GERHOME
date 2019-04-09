using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YtahUI
{
    public class User
    {
        public string pcid;
        public string user;
        public string ip;
        public string admin;
        public User(string id, string userr, string ipp, string isadmin)
        {
            pcid = id;
            user = userr;
            ip = ipp;
            admin = isadmin;
        }
    }
}
