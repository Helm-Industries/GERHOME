using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QGF_Administration
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress ip = IPAddress.Parse("78.114.52.238");
            int port = 5000;
            TcpClient client = new TcpClient();
            client.Connect(ip, port);
            NetworkStream ns = client.GetStream();
            Thread thread = new Thread(o => ReceiveData((TcpClient)o));

            thread.Start(client);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Plateforme d'Administration de QuickGameFinder, il est interdit de donner ce logiciel a une personne \r\nne faisant pas partit de l'équipe.");
            Console.WriteLine("");
            Console.WriteLine("Commandes : 'help'");
            MySqlConnection connection = new MySqlConnection("datasource=mysql-quickgamefinder.alwaysdata.net; port=3306;Initial Catalog='quickgamefinder_dev';username=169942;password=alexandre");
            connection.Open();
            string password = "9856943630rpz";
            while (true)
            {
                string sw = Console.ReadLine();
                string s;

                if (sw.Contains("sendglobal")){
                    s = sw + "|" + password;
                    byte[] buffer = Encoding.ASCII.GetBytes(s);
                    ns.Write(buffer, 0, buffer.Length);
                }
                else if (sw.Contains("help")){
                            Console.WriteLine("----------------------------------------------------------------------------------");
                            Console.WriteLine("sendglobal|votre message  <- Envoie une notification a tout les membres connectés");
                            Console.WriteLine("sendnotif|username|votre message <- Envoie une notification a un membre en particulier");
                            Console.WriteLine("ban|username <- bannir un membre");
                            Console.WriteLine("unban|username <- unban");
                            Console.WriteLine("kick|username <- ferme le logiciel d'un membre");
                            Console.WriteLine("kickall <- Ferme le logiciel de tout les membres");
                            Console.WriteLine("forcediscord|username|raison <- Force un membre a rejoindre le discord");
                            Console.WriteLine("----------------------------------------------------------------------------------");
                }
                else if(sw.Contains("sendnotif"))
                {
                    s = sw + "|" + password;
                    byte[] buffer = Encoding.ASCII.GetBytes(s);
                    ns.Write(buffer, 0, buffer.Length);
                }
                else if(sw.Contains("ban"))
                {
                    string[] splitter = sw.Split('|');
                    MySqlCommand c = new MySqlCommand("UPDATE `users` SET `ban` = '1' WHERE `users`.`username` = '" + splitter[1] +"' ", connection);
                    try
                    {
                        c.ExecuteNonQuery();
                        Console.WriteLine("Terminé");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erreur : " + e.ToString());
                    }
                }
                else if(sw.Contains("unban"))
                {
                    string[] splitter = sw.Split('|');
                    MySqlCommand c = new MySqlCommand("UPDATE `users` SET `ban` = '0' WHERE `users`.`username` = '" + splitter[1] + "' AND `users`.`ban` = '1'", connection);
                    try
                    {
                        c.ExecuteNonQuery();
                        Console.WriteLine("Terminé");
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("Erreur : " + e.ToString());
                    }
                }
                else if(sw.Contains("kick"))
                {
                    s = sw + "|" + password;
                    byte[] buffer = Encoding.ASCII.GetBytes(s);
                    ns.Write(buffer, 0, buffer.Length);
                }
                else if (sw.Contains("kickall"))
                {
                    s = sw + "|" + password;
                    byte[] buffer = Encoding.ASCII.GetBytes(s);
                    ns.Write(buffer, 0, buffer.Length);
                }
                else if (sw.Contains("forcediscord"))
                {
                    s = sw + "|" + password;
                    byte[] buffer = Encoding.ASCII.GetBytes(s);
                    ns.Write(buffer, 0, buffer.Length);
                }
            }

        }

        static void ReceiveData(TcpClient client)
        {
            NetworkStream ns = client.GetStream();
            byte[] receivedBytes = new byte[1024];
            int byte_count;

            while ((byte_count = ns.Read(receivedBytes, 0, receivedBytes.Length)) > 0)
            {
                Console.Write(Encoding.ASCII.GetString(receivedBytes, 0, byte_count));
            }
        }
    }
}
