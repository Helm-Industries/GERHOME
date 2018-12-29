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
            label1.Text = Perso.Me.username;
            logConsole.AppendText("Bienvenue sur YTAH poto");
            logConsole.ScrollToCaret();
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
            if(MessageDisplayer.todisplay.Count > 0)
            {
                foreach(string s in MessageDisplayer.todisplay)
                {
                    logConsole.AppendText("\r\n" + s);

                    logConsole.ScrollToCaret();
                }
            }
        }
    }
}
