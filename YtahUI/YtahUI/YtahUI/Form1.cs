using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YtahUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IPAddress ip = IPAddress.Parse("78.114.52.238");
            int port = 5000;
            TcpClient client = new TcpClient();
            client.Connect(ip, port);
            NetworkStream ns = client.GetStream();
            Thread thread = new Thread(o => ReceiveData((TcpClient)o));

            thread.Start(client);
            byte[] buffer = Encoding.ASCII.GetBytes("GetUsers");
            ns.Write(buffer, 0, buffer.Length);
           
            new Thread(() =>
            {
                GetUsers();
            }).Start();
            r = richTextBox1;
        }
        public void GetUsers()
        {
            while (true)
            {
                if (users.Count != listView1.Items.Count)
                {
                    listView1.Items.Clear();
                    foreach(User u in users)
                    {
                        ListViewItem lvi = new ListViewItem(u.pcid);
                        lvi.SubItems.Add(u.user);
                        lvi.SubItems.Add(u.admin);
                        lvi.SubItems.Add(u.ip);
                        try
                        {
                            listView1.Items.Add(lvi);
                        }

                        catch
                        {

                        }
                    }
                }
            }
        }
        public static List<User> users = new List<User>();
        public enum LogType
        {
            SERVER,
            CLIENT,
            INFO,
            ERROR
        }
        public static RichTextBox r;
        public static void Log(string text, LogType log, RichTextBox rr)
        {
            Action log_callback = (Action)delegate
            {
                switch (log)
                {
                    case LogType.SERVER:
                        text = "[RCV] - " + text;
                        rr.SelectionColor = Color.Aqua;
                        break;
                    case LogType.CLIENT:
                        text = "[SND] - " + text;
                        rr.SelectionColor = Color.OrangeRed;
                        break;
                    case LogType.ERROR:
                        text = "[ERROR] - " + text;
                        rr.SelectionColor = Color.Red;
                        break;
                    case LogType.INFO:
                        
                        rr.SelectionColor = Color.Cyan;
                        break;
                }
                rr.AppendText("\r\n" + text);

                rr.ScrollToCaret();
            };
            try
            {
                rr.Invoke(log_callback);
            }
            catch
            {

            }
        }
        static void ReceiveData(TcpClient client)
        {
             clients = client;
             ns = client.GetStream();
            byte[] receivedBytes = new byte[1024];
            int byte_count;

            while ((byte_count = ns.Read(receivedBytes, 0, receivedBytes.Length)) > 0)
            {
                string data = Encoding.ASCII.GetString(receivedBytes);
                Log(data, LogType.INFO, r);
                string[] splitter = data.Split('|');
            
                if (data.Contains("empty"))
                {
                    MessageBox.Show("Aucun utilisateur connecté");
                }
                if (data.Contains("users"))
                {
                    users.Clear();
                    
                    splitter[0].Replace("users|", "");
                 
                    foreach(string s in splitter) // users|pc_id;user;ip|
                    {
                    
                        if (s != "users" && s != "users|")
                        {
                            try
                            {
                                string[] infos = s.Split(';');

                                string pcid = infos[0];
                                string user = infos[1];
                                string isadmin = infos[2];
                      
                                User u = new User(pcid, user, "x", isadmin);
                                users.Add(u);
                               
                            }
                            catch
                            {

                            }
                        }

                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public static User selected;
        public static TcpClient clients;
        public static NetworkStream ns;
        public static bool isglobal = true;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                selecteduser.Text = "Utilisateur : " + listView1.SelectedItems[0].SubItems[1].Text + "(" + listView1.SelectedItems[0].SubItems[0].Text + ")";
                User u = new User(listView1.SelectedItems[0].SubItems[0].Text, listView1.SelectedItems[0].SubItems[1].Text, "x", listView1.SelectedItems[0].SubItems[2].Text);
                selected = u;
                isglobal = false;
            }
            catch
            {
                selecteduser.Text = "Utilisateur : (Global)";
                selected = null;
                isglobal = true;
            }
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void SendCommand(string command)
        {
            string final = "SC|";
            if(isglobal == true)
            {
                final = final + "y|";
            }
            else
            {
                final = final + selected.pcid + "|";
            }
            final = final + command;
            byte[] b = Encoding.ASCII.GetBytes(final);
            ns.Write(b,0,b.Length);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SendCommand("update");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void startproc_Click(object sender, EventArgs e)
        {
            SendCommand("startproc;"+textBox1.Text);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
