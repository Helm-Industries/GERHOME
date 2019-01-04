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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
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
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "♀ USERNAME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // logConsole
            // 
            this.logConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logConsole.BackColor = System.Drawing.Color.Black;
            this.logConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logConsole.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logConsole.ForeColor = System.Drawing.Color.White;
            this.logConsole.Location = new System.Drawing.Point(650, 63);
            this.logConsole.Name = "logConsole";
            this.logConsole.ReadOnly = true;
            this.logConsole.Size = new System.Drawing.Size(600, 606);
            this.logConsole.TabIndex = 2;
            this.logConsole.Text = "";
            this.logConsole.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(651, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(600, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "✎ ACTIVITÉE EN TEMPS REEL...";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserList
            // 
            this.UserList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.UserList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.UserList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.session_user,
            this.session_postID,
            this.session_hasAdminRights,
            this.session_IP});
            this.UserList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserList.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserList.ForeColor = System.Drawing.Color.White;
            this.UserList.FullRowSelect = true;
            this.UserList.Location = new System.Drawing.Point(10, 63);
            this.UserList.MultiSelect = false;
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(600, 606);
            this.UserList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.UserList.TabIndex = 4;
            this.UserList.UseCompatibleStateImageBehavior = false;
            this.UserList.View = System.Windows.Forms.View.Details;
            this.UserList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // session_user
            // 
            this.session_user.Text = "Nom d\'utilisateur";
            this.session_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.session_user.Width = 136;
            // 
            // session_postID
            // 
            this.session_postID.Text = "Poste";
            this.session_postID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.session_postID.Width = 145;
            // 
            // session_hasAdminRights
            // 
            this.session_hasAdminRights.Text = "Admin Rights";
            this.session_hasAdminRights.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.session_hasAdminRights.Width = 96;
            // 
            // session_IP
            // 
            this.session_IP.Text = "Adresse IP";
            this.session_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.session_IP.Width = 223;
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

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