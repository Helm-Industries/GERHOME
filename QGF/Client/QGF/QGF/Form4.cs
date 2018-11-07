using QGF.Network;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QGF
{
    public partial class Form4 : Form
    {
        private const int CS_dropshadow = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CS_dropshadow;
                return cp;
            }
        }
        public Form4()
        {
            InitializeComponent();
            panel1.Select();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string msg = "DisconnectRequest";
            //SocketMain.SendData(Encoding.ASCII.GetBytes(msg), SocketMain.ns);
            
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void searchgame_button_Click(object sender, EventArgs e)
        {

        }

        private void creategroup_button_Click(object sender, EventArgs e)
        {

        }

        private void username_label_Click(object sender, EventArgs e)
        {

        }

        private void rank_label_Click(object sender, EventArgs e)
        {

        }

        private void online_label_Click(object sender, EventArgs e)
        {

        }

        private void created_label_Click(object sender, EventArgs e)
        {

        }

        private void uprank_label_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/T_Jze");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Process.Start("http://quickgamefinder.com/");
        }

        private void disconect_button_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {

        }
    }
}
