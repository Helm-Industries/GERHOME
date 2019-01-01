using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YTAH_COMMUNITY.IO;
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
                this.Text = Perso.Me.username + " CONTRÔLE : " + Perso.Me.selected_user.username ;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
            }
            this.BringToFront();
            timer1.Start();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                this.Text = Perso.Me.username + " CONTRÔLE : " + Perso.Me.selected_user.username;
                
            }
            catch
            {

            }
            try
            {
                if(CustomProcess.customProcesses.Count > 0)
                {
                    foreach(CustomProcess p in CustomProcess.customProcesses)
                    {
                        ListViewItem li = new ListViewItem(p.processname);
                        li.SubItems.Add(p.processid);
                        li.SubItems.Add(p.processtitle);
                        process_ListView.Items.Add(li);
                        CustomProcess.customProcesses.Remove(p);
                    }
                }
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
            process_ListView.Items.Clear();
            Network.ListProcess();
        }

        private void toolStripTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                Network.SendPopUp(toolStripTextBox3.Text);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Network.StartProcess(toolStripTextBox1.Text);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Network.KillProcess(toolStripTextBox2.Text);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void eteindreLePCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Network.ShutDown();
        }

        private void quiSommesNousToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void afficherLaideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
            
        }
    }
}
