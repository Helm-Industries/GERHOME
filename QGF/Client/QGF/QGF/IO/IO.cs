using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QGF.IO
{
    public class IO
    {
        public static string GetSavedData() {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/qgfconfig";
            string msg = "";
            
            string txtpath = path + "/config.txt";
            try
            {
                Directory.CreateDirectory(path);
            }
            catch
            {

            }
            File.Create(txtpath);
               string[] lines = File.ReadAllLines(txtpath);
                msg  = lines[0] + "|" + lines[1];
                
            
            return msg;
        }
    }
}
