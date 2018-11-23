using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QGF
{
    public partial class Room : UserControl
    {
        public Room(string author, int currentplayer, int maxplayer, string isprivate, string roomname, string roomdesc, string game, int RoomID, string rank)
        {
            InitializeComponent();
            if(rank == "free")
            {
                rankpic.Image = Properties.Resources.free;
                bunifuLabel2.ForeColor = Color.Gray;
                bunifuLabel2.Text = "Free";
            }
            else
            {
                rankpic.Image = Properties.Resources.premium;
                bunifuLabel2.ForeColor = Color.Goldenrod;
                bunifuLabel2.Text = "Premium";
            }
            string ispublic = isprivate;

            bunifuLabel1.Text = "Jeu: " + game + "\r\n" + currentplayers.ToString() + "/" + maxplayer.ToString() + " joueurs - " ;
        }
        public static string gameID;
        public static int currentplayers;
        public static int maxplayers;
        public bool isPremium;
        
        public string isPublic;

        private void Room_Load(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void rank_Click(object sender, EventArgs e)
        {

        }
    }
}
