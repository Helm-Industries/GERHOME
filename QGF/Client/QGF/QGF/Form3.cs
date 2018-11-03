using QGF.Network;
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



        public Form3()
        {
            InitializeComponent();
           
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
            if(bunifuCheckBox2.Checked != true)
            {
                MessageBox.Show("Veuillez accepter les CGU");
            } 
            if(identifiant.Length > 0 && email.Length > 0 && password.Length > 0 && confirm == password && bunifuCheckBox2.Checked == true)
            {             
                string msg = "RegisterRequest|" + identifiant + "|" + email + "|" + password;
                byte[] bmsg = Encoding.ASCII.GetBytes(msg);
                SocketMain.SendData(bmsg, SocketMain.ns);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
        }

    }
}
