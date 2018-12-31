using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YTAH_COMMUNITY.IO;

namespace YTAH_COMMUNITY
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Text = Perso.Me.username + " | YTAH PROJECT";
            label1.Text = "Compte : " + Perso.Me.username;
            logConsole.AppendText("Bienvenue sur YTAH " + Perso.Me.username);
            logConsole.ScrollToCaret();
            timer1.Start();
            Network.GetUsers();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(MessageDisplayer.todisplay.Count != 0)
            {
                foreach(string s in MessageDisplayer.todisplay)
                {
                    if (s.Contains("connecté")&&s.Contains("admin"))
                    {
                        logConsole.SelectionColor = Color.Coral;
                    }
                    else if (s.Contains("contrô"))
                    {
                        logConsole.SelectionColor = Color.Cyan;
                    }
                    else if (s.Contains("Chargement"))
                    {
                        logConsole.SelectionColor = Color.White;
                    }
                    else if (s.Contains("Utilisateur") && s.Contains("connecté"))
                    {
                        logConsole.SelectionColor = Color.White;
                    }
                    logConsole.AppendText("\r\n" + s);

                    logConsole.ScrollToCaret();
                    
                }
                MessageDisplayer.todisplay.Clear();
            }
            if(UserList.Items.Count != User.users.Count)
            {
                UserList.Items.Clear();
                foreach(User u in User.users)
                {
                    var item = new ListViewItem(u.username);
                    item.SubItems.Add(u.poste);
                    item.SubItems.Add(u.admin);
                    item.SubItems.Add(u.ip);
                    UserList.Items.Add(item);
                }
               
            }
            MessageDisplayer.hour = MessageDisplayer.GetHour();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               // selecteduser_label.Text = UserList.SelectedItems[0].SubItems[0].Text;
                string poste = UserList.SelectedItems[0].SubItems[1].Text;
                Network.SelectUser(poste);
            }
            catch
            {

            }
        }

        private void selecteduser_label_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
