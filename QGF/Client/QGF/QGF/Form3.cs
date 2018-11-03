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

namespace QGF
{
    public partial class Form3 : Form
    {
        IPAddress ip = IPAddress.Parse("78.114.55.200");
        int port = 5000;
        TcpClient client = new TcpClient();
        Thread thread = new Thread(o => ReceiveData((TcpClient)o));
        NetworkStream ns;


        public Form3()
        {
            InitializeComponent();
            try
            {
                client.Connect(ip, port);
            }
            catch
            {
                MessageBox.Show("Serveur Indisponible");
            }
            ns = client.GetStream();
            thread.Start(client);
            string s;
            while (!string.IsNullOrEmpty((s = Console.ReadLine())))
            {
                byte[] buffer = Encoding.ASCII.GetBytes(s);
                ns.Write(buffer, 0, buffer.Length);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuTextBox1_TextChange(object sender, EventArgs e) // identifiant
        {

        }

        private void bunifuTextBox3_TextChange(object sender, EventArgs e) //email
        {

        }

        private void bunifuTextBox2_TextChange(object sender, EventArgs e) //pass
        {

        }

        private void bunifuTextBox4_TextChange(object sender, EventArgs e) //confirm
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCheckBox2_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e) //cgu
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e) // inscription
        {
            #region changement couleur
            string identifiant = bunifuTextBox1.Text;
            string email = bunifuTextBox3.Text;
            string password = bunifuTextBox2.Text;
            string confirm = bunifuTextBox4.Text;
            if(identifiant.Length == 0)
            {
                bunifuTextBox1.BorderColorActive = Color.Red;
                bunifuTextBox1.BorderColorIdle = Color.Red;
            }
            else
            {
                bunifuTextBox1.BorderColorActive = Color.FromArgb(30, 41, 58);
            }
            if(email.Length == 0 || !email.Contains("@") || !email.Contains("."))
            {
                bunifuTextBox3.BorderColorActive = Color.Red;
                bunifuTextBox3.BorderColorIdle = Color.Red;

            }
            else
            {
                bunifuTextBox1.BorderColorActive = Color.FromArgb(30, 41, 58);
            }
            if(password.Length == 0)
            {
                bunifuTextBox2.BorderColorActive = Color.Red;
                bunifuTextBox2.BorderColorIdle = Color.Red;

            }
            else
            {
                bunifuTextBox2.BorderColorActive = Color.FromArgb(30, 41, 58);
            }
            if(confirm != password)
            {
                bunifuTextBox2.BorderColorActive = Color.Red;
                bunifuTextBox4.BorderColorActive = Color.Red;
                bunifuTextBox2.BorderColorIdle = Color.Red;
                bunifuTextBox4.BorderColorIdle = Color.Red;

            }
            else
            {
                bunifuTextBox2.BorderColorActive = Color.FromArgb(30, 41, 58);
                bunifuTextBox4.BorderColorActive = Color.FromArgb(30, 41, 58);

            }
            #endregion
            if(identifiant.Length > 0 && email.Length > 0 && password.Length > 0 && confirm == password)
            {
               
                string msg = "RegisterRequest|" + identifiant + "|" + email + "|" + password;
                byte[] bmsg = Encoding.ASCII.GetBytes(msg);
                ns.Write(bmsg, 0, bmsg.Length);
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
               
                if (data.Contains("success"))
                {
                    SendToConnect();
                }
                if (data.Contains("failed"))
                {
                    MessageBox.Show("Identifiants / Email déjà pris");
                }
            }
        }
        static void SendToConnect()
        {
            MessageBox.Show("Inscription réussie, retournez à la connexion pour continuer");
           
            
        }
        static void ShowHideForm(Form form, bool show /* otherwise hide */)
        {
            if (form.InvokeRequired)
            {
                form.Invoke(new Action<Form, bool>((formInstance, isShow) => {
                    if (isShow)
                        formInstance.Show();
                    else
                        formInstance.Hide();
                }), form, show);
            }
            else
            {
                if (show)
                    form.Show();
                else
                    form.Hide();
            } 
        } 
        private void label5_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
        }
         void FormHandler_Form1Hide()
        {
           
        }
    }
}
