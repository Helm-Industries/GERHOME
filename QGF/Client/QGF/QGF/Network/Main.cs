using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QGF.Network
{
    public class SocketMain
    {
        public static string username;
        public static IPAddress ip = IPAddress.Parse("78.114.55.200");
        public static int port = 5000;
        public static TcpClient client = new TcpClient();
        public static Thread thread = new Thread(o => ReceiveData((TcpClient)o));
        public static NetworkStream ns;
        public static bool connected = false;
        public static void Connect()
        {
            if (connected == false)
            {
                try
                {
                    client.Connect(ip, port);
                    connected = true;
                }
                catch(Exception e)
                {
                    MessageBox.Show("Le serveur est actuellement indisponible: " + e.ToString());
                    Application.Exit();
                }
                try
                {
                    ns = client.GetStream();
                    thread.Start(client);
                }
                catch
                {

                }

            }
                string s;
                while (!string.IsNullOrEmpty((s = Console.ReadLine())))
                {
                    byte[] buffer = Encoding.ASCII.GetBytes(s);
                    ns.Write(buffer, 0, buffer.Length);
                }
            
        }
        public static string data;
        static void ReceiveData(TcpClient client)
        {
            
            NetworkStream ns = client.GetStream();
            byte[] receivedBytes = new byte[1024];
            int byte_count;

            while ((byte_count = ns.Read(receivedBytes, 0, receivedBytes.Length)) > 0)
            {
                data = (Encoding.ASCII.GetString(receivedBytes, 0, byte_count));
                if (data.Contains("regsuccess"))
                {
                    SendToConnect();
                }
                if (data.Contains("regfailed"))
                {
                    MessageBox.Show("Identifiants / Email déjà pris");
                }
                if (data.Contains("authsuccess"))
                {
                     MessageBox.Show("Connecté avec succès");
                }
                if (data.Contains("authbanned"))
                {
                    
                    MessageBox.Show("Ce compte à été banni de façon permanente de la plateforme QGF");
                }
                if (data.Contains("authfailed"))
                {
                    
                    MessageBox.Show("Impossible de se connecter avec ces identifiants");
                }
            }
        }
        static void SendToConnect()
        {
            MessageBox.Show("Inscription réussie, retournez à la connexion pour continuer");
        }
        public static void SendData(byte[] b, NetworkStream nss)
        {
            nss.Write(b, 0, b.Length);
        }
         public static void CloseSocket()
        {
            try
            {
                client.Client.Shutdown(SocketShutdown.Send);
                thread.Join();
                ns.Close();
                client.Close();
            }
            catch
            {
                Application.Exit();
            }
        }

    }
}
