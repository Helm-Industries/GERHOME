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
        public static string GetHour()
        {
            string toreturn = "[";
             toreturn = toreturn + DateTime.Now.ToString();
            toreturn = toreturn + "] - ";
            return toreturn;
        }
        static string hour = GetHour();
        public static void Log(string log)
        {
            todisplay.Add(log);
        }
        public static void AdminConnect(string name)
        {
            if (name.Contains("LOG"))
            {
                name.Replace("LOG", "");
            }
            
            todisplay.Add(hour + name + " S'est connecté en tant qu'admin");
        }
        public static void SelectBool(bool success, string admin, string selecteduser)
        {
            switch (success)
            {
                case true:
                    todisplay.Add(hour + "Utilisateur " + selecteduser + " contrôlé par " + admin);
                    break;
                case false:
                    todisplay.Add(hour + admin + " Echec du contrôle de " + selecteduser);
                    break;
            }
        }
        public static void LoadUsers()
        {
            todisplay.Add(hour + "Chargement des utilisateurs en cour");
        }
        public static void UsersLoaded()
        {
            todisplay.Add(hour + User.users.Count.ToString() + " Utilisateurs chargés");
        }
    }
}
