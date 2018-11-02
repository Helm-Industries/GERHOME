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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            timer1.Start();
        }

        int opacity = 0;
        bool inout = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (inout == false)
            {
                FadeIn();
            }
            if(inout == true)
            {
                FadeOut();
            }
        }
        int fadingSpeed = 4;

        public void FadeIn()
        {
            label1.ForeColor = Color.FromArgb(label1.ForeColor.R + fadingSpeed, label1.ForeColor.G + fadingSpeed, label1.ForeColor.B + fadingSpeed);
            label2.ForeColor = Color.FromArgb(label1.ForeColor.R + fadingSpeed, label1.ForeColor.G + fadingSpeed, label1.ForeColor.B + fadingSpeed);
            if (label1.ForeColor.R >= this.BackColor.R && inout == false)
            {

                label1.ForeColor = this.BackColor;
                label2.ForeColor = this.BackColor;
                inout = true;
            }
        }
        public void FadeOut()
        {
           try
            {
                label1.ForeColor = Color.FromArgb(label1.ForeColor.R - fadingSpeed, label1.ForeColor.G - fadingSpeed, label1.ForeColor.B - fadingSpeed);
                label2.ForeColor = Color.FromArgb(label1.ForeColor.R - fadingSpeed, label1.ForeColor.G - fadingSpeed, label1.ForeColor.B - fadingSpeed);
            }
            catch
            {
                //label1.ForeColor = this.BackColor;
                //label2.ForeColor = this.BackColor;

                inout = false;
            }
            if (label1.ForeColor.R >= this.BackColor.R && inout == false)
            {
                label1.ForeColor = this.BackColor;
                label2.ForeColor = this.BackColor;
                FadeIn();
                inout = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
