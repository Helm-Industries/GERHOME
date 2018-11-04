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

namespace QGF
{
    public partial class Form1 : Form
    {
        public void GetData()
        {
            if(Properties.Settings.Default.check == true)
            {
                
                password_text.Text = Properties.Settings.Default.password;
                password = Properties.Settings.Default.password;
                password_text.Text = password;
                username = Properties.Settings.Default.username;
                username_text.Text = username;
            }
        }
        public Form1()
        {
            InitializeComponent();
            GetData();
            panel1.Select();
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
                Properties.Settings.Default.check = true;
                Properties.Settings.Default.username = username_text.Text;
                Properties.Settings.Default.password = password_text.Text;
                Properties.Settings.Default.Save();
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

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            this.Hide();
            frm.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
