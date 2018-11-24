using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QGF
{
    public partial class Form7 : Form
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

                public Form7()
        {
            InitializeComponent();
            int i = 0;
            while( i < 10)
            {
                user_profil p = new user_profil(); 
                flowLayoutPanel2.Controls.Add(p);
                i++;
            }
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chat1_Load(object sender, EventArgs e)
        {

        }
    }
}
