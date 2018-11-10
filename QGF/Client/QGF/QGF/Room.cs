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
        public Room()
        {
            InitializeComponent();
            if(currentplayers == maxplayers)
            {
                join_button.Enabled = false;
            }
            else
            {
                join_button.Enabled = true;
            }
        }
        public static string gameID;
        public static int currentplayers;
        public static int maxplayers;
        public bool isPremium;
        public bool isPublic;

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
