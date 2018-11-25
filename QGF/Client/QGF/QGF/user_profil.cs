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
    public partial class user_profil : UserControl
    {
        public user_profil(string username, bool admin)
        {
            InitializeComponent();
            userprofil.Text = username;
            if(admin == true)
            {
                userprofil.ForeColor = Color.Red;
            }
        }

        private void user_profil_Load(object sender, EventArgs e)
        {

        }

        private void userprofil_Click(object sender, EventArgs e)
        {

        }
    }
}
