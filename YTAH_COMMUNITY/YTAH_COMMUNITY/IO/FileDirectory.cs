using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTAH_COMMUNITY.IO
{
    public class FileDirectory
    {
        public static List<FileDirectory> fileDirectories = new List<FileDirectory>();
        public string fileName;
        public FileDirectory(string fn)
        {
            fileName = fn;
        }
    }
}
