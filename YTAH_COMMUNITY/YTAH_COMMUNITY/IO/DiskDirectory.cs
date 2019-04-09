using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTAH_COMMUNITY.IO
{
    public class DiskDirectory
    {
        public static List<DiskDirectory> diskDirectories = new List<DiskDirectory>();
        public string DiskName;
        public DiskDirectory(string dn)
        {
            DiskName = dn;
        }
    }
}
