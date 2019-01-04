using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTAH_COMMUNITY.IO
{
    public class CustomDirectory
    {
        public static List<CustomDirectory> customDirectories = new List<CustomDirectory>();
        public string foldername;
        public CustomDirectory(string fn)
        {
            foldername = fn;
        }
    }
}
