using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTAH_COMMUNITY.IO
{
    public class CustomThing
    {
        public static List<CustomThing> customThings = new List<CustomThing>();
        public string name;
        public CustomThing(string n)
        {
            name = n;
        }
    }
}
