using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTAH_COMMUNITY.IO
{
    public class CustomProcess
    {
        public static List<CustomProcess> customProcesses = new List<CustomProcess>();
        public  string processname;
        public  string processid;
        public  string processtitle;
        public CustomProcess(string prname, string prid, string prtitle)
        {
            processname = prname;
            processid = prid;
            processtitle = prtitle;
        }
    }
}
