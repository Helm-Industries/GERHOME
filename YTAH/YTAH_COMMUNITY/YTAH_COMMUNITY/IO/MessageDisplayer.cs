using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YTAH_COMMUNITY.IO
{
    public class MessageDisplayer
    {
        public static List<string> todisplay = new List<string>();
        public static void AdminConnect(string name)
        {
            todisplay.Add(name + " S'est connecté en tant qu'admin");
        }
    }
}
