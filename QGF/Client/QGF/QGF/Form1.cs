using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using QGF.Network;
using System.IO;
using QGF.IO;

namespace QGF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string msg = IO.IO.GetSavedData();
            string[] splitter = msg.Split('|');
            username_text.Text = splitter[0];
            password_text.Text = splitter[1];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            this.Hide();
            frm.ShowDialog();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (bunifuCheckBox2.Checked == true)
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/qgfconfig";
                string msg = "";
               
                File.Create(path);
                string txtpath = path + "/config.txt";
                StreamWriter strm = File.CreateText(txtpath);
                
                    strm.Flush();
                    strm.WriteLine(username_text.Text);
                    strm.WriteLine(password_text.Text);
                
            }
            if (username_text.Text != "" && password_text.Text != "")
            {
                string msg = "AuthRequest|" + username + "|" + password;
                byte[] bmsg = Encoding.ASCII.GetBytes(msg);
                SocketMain.SendData(bmsg, SocketMain.ns);

            }
        }

        private void bunifuCheckBox2_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            
        }
        string username;
        string password;
        private void username_text_TextChange(object sender, EventArgs e)
        {
            username = username_text.Text;
        }

        private void password_text_TextChange(object sender, EventArgs e)
        {
            password = password_text.Text;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SocketMain.CloseSocket();
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
