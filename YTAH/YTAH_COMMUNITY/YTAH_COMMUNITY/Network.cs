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
                thread.Start(client);
                
              
                    Form1.current = Form1.State.CONNECTE;
                

            }
            catch
            {
                Form1.current = Form1.State.DECONNECTE;
            }
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
                    if (d.Contains("adminconnect"))
                    {
                        string username = splitter[1];
                        MessageDisplayer.AdminConnect(username);
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
