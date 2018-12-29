using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace YTAH_COMMUNITY
{
    public partial class Form1 : Form
    {
        public static string todo = "keep";
        public enum State
        {
            CONNEXION,
            CONNECTE,
            DECONNECTE
        }
        public static State current = new State();
        public Form1()
        {
            InitializeComponent();
            current = State.CONNEXION;
            timer1.Start();
            new Thread(() =>
            {
                Network.Connect();
            }).Start();
          
         
       
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public static string username;
        public static string password;
        
        private void button1_Click(object sender, EventArgs e)
        {
          
            if (Network.client.Connected ==true)
            {
                 username = textBox1.Text;
                password = textBox2.Text;
               string msg = "AuthRequest|" + username + "|" + password;
                Network.SendMessage(msg);
            }
            else
            {
                MessageBox.Show("La connexion au serveur n'a pas encore été établie");
            }
        }
    
        private void state_label_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(todo != "keep")
            {
                this.Hide();
            }
            if (Network.client.Connected == false)
            {
                switch (current)
                {
                    case State.CONNEXION:
                        state_label.Text = "Connexion au serveur en cour...";
                        state_label.ForeColor = Color.Coral;
                        break;
                    case State.CONNECTE:
                        state_label.Text = "Connecté au serveur !";
                        state_label.ForeColor = Color.LightGreen;
                        break;
                    case State.DECONNECTE:
                        state_label.Text = "Connexion au serveur impossible !";
                        state_label.ForeColor = Color.Red;
                        break;
                }

            }
            else
            {
                state_label.Text = "Connecté au serveur !";
                state_label.ForeColor = Color.LightGreen;
            }
        }
    }
}
