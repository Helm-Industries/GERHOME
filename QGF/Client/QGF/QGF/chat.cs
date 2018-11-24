﻿using System;
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
    public partial class chat : UserControl
    {
        public chat()
        {
            InitializeComponent();
        }
        public chat(string message, string auteur, msgtype m)
        {
            InitializeComponent();
            label1.Text = auteur;
            label2.Text = message;
            if (m == msgtype.In)
            {
                this.BackColor = Color.Gainsboro;
            }
            else
            {
                this.BackColor = Color.FromArgb(27, 73, 131);
            }
            SetHeight();
        }
        private void chat_Load(object sender, EventArgs e)
        {

        }
        public enum msgtype
        {
            In,
            Out
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        void SetHeight()
        {
            Size maxSize = new Size(495, int.MaxValue);
            Graphics g = CreateGraphics();
            SizeF size = g.MeasureString(label2.Text, label2.Font, label2.Width);
            label2.Height = int.Parse(Math.Round(size.Height + 2, 0).ToString());
            label1.Top = label2.Top + 10;
            this.Height = label2.Height + 10;
            
        }

        private void chat_Resize(object sender, EventArgs e)
        {
            SetHeight();
        }
    }
}
