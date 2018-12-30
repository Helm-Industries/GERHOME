namespace YTAH_COMMUNITY
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.logConsole = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.UserList = new System.Windows.Forms.ListView();
            this.session_user = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.session_postID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.session_hasAdminRights = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.session_IP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "USERNAME";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // logConsole
            // 
            this.logConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.logConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logConsole.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logConsole.ForeColor = System.Drawing.Color.White;
            this.logConsole.Location = new System.Drawing.Point(651, 61);
            this.logConsole.Name = "logConsole";
            this.logConsole.ReadOnly = true;
            this.logConsole.Size = new System.Drawing.Size(600, 606);
            this.logConsole.TabIndex = 2;
            this.logConsole.Text = "";
            this.logConsole.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(652, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(597, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "ACTIVITE EN TEMPS REEL";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserList
            // 
            this.UserList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.UserList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.session_user,
            this.session_postID,
            this.session_hasAdminRights,
            this.session_IP});
            this.UserList.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserList.ForeColor = System.Drawing.Color.White;
            this.UserList.FullRowSelect = true;
            this.UserList.Location = new System.Drawing.Point(10, 63);
            this.UserList.MultiSelect = false;
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(600, 606);
            this.UserList.TabIndex = 4;
            this.UserList.UseCompatibleStateImageBehavior = false;
            this.UserList.View = System.Windows.Forms.View.Details;
            this.UserList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // session_user
            // 
            this.session_user.Text = "Nom d\'utilisateur";
            this.session_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.session_user.Width = 130;
            // 
            // session_postID
            // 
            this.session_postID.Text = "Poste";
            this.session_postID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.session_postID.Width = 130;
            // 
            // session_hasAdminRights
            // 
            this.session_hasAdminRights.Text = "Admin Rights";
            this.session_hasAdminRights.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.session_hasAdminRights.Width = 81;
            // 
            // session_IP
            // 
            this.session_IP.Text = "Adresse IP";
            this.session_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.session_IP.Width = 180;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.UserList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logConsole);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.RichTextBox logConsole;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView UserList;
        private System.Windows.Forms.ColumnHeader session_user;
        private System.Windows.Forms.ColumnHeader session_postID;
        private System.Windows.Forms.ColumnHeader session_hasAdminRights;
        private System.Windows.Forms.ColumnHeader session_IP;
    }
}