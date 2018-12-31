using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YTAH_COMMUNITY
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
            try
            {
                this.Text = Perso.Me.username + " Contrôle : " + Perso.Me.selected_user.username ;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
            }
           
            timer1.Start();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                this.Text = Perso.Me.username + " Contrôle : " + Perso.Me.selected_user.username;
                
            }
            catch
            {

            }
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void seDeconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void demarrerUnPrrocesusToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void lancerUneAttaqueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listerLesProcessusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                Network.SendPopUp(toolStripTextBox3.Text);
                
            }
        }
    }
}
