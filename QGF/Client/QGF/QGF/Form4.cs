using QGF.Network;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QGF
{
    public partial class Form4 : Form
    {
        private const int CS_dropshadow = 0x00020000;
        public List<Room> roomlist = new List<Room>();
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
            if(Me.rank == "premium")
            {
                maxplayer_slider.MaximumValue = 15;
            }
            else
            {
                maxplayer_slider.MaximumValue = 5;
            }
            int counter = 10;
            while(counter != 0)
            {
                Room room = new Room();
                flowLayoutPanel1.Controls.Add(room);
                roomlist.Add(room);
                counter--;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void searchgame_button_Click(object sender, EventArgs e)
        {

        }

        private void creategroup_button_Click(object sender, EventArgs e)
        {
            create_group_panel.Visible = true;
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
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                try
                {
                    string msg = "DisconnectRequest";
                    SocketMain.SendData(Encoding.ASCII.GetBytes(msg), SocketMain.ns);
                }
                catch
                {

                }
            }).Start();
           
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/T_Jze");
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Process.Start("http://quickgamefinder.com/");
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuSlider1_ValueChanged(object sender, EventArgs e)
        {
            maxplayer_label.Text = maxplayer_slider.Value.ToString();
            //slidertext.Location = new Point(bunifuSlider1.HorizontalScroll.Value, slidertext.Location.Y);
            if(maxplayer_slider.Value == 0)
            {
                maxplayer_slider.Value = 1;
            }
        }

        private void slidertext_Click(object sender, EventArgs e)
        {

        }

        private void label_changer_Click(object sender, EventArgs e)
        {

        }

        private void bunifuToggleSwitch1_OnValuechange(object sender, EventArgs e)
        {
            if(bunifuToggleSwitch1.Value == false)
            {
                label_changer.Text = "Groupe public";
            }
            else
            {
                label_changer.Text = "Groupe privé";
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            create_group_panel.Visible = false;
        }

        private void create_group_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void username_text_TextChange(object sender, EventArgs e)
        {

        }
    }
}
