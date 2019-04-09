namespace YtahUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.pc_id_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.user_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isadmin_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ipadress_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.selecteduser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.shutdown = new System.Windows.Forms.Button();
            this.startproc = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pc_id_column,
            this.user_column,
            this.isadmin_column,
            this.ipadress_column});
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(11, 68);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(542, 601);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // pc_id_column
            // 
            this.pc_id_column.Text = "ID-PC";
            this.pc_id_column.Width = 120;
            // 
            // user_column
            // 
            this.user_column.Text = "User";
            this.user_column.Width = 120;
            // 
            // isadmin_column
            // 
            this.isadmin_column.Text = "Admin";
            this.isadmin_column.Width = 120;
            // 
            // ipadress_column
            // 
            this.ipadress_column.Text = "Adresse IP";
            this.ipadress_column.Width = 180;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // selecteduser
            // 
            this.selecteduser.AutoSize = true;
            this.selecteduser.Font = new System.Drawing.Font("Roboto Cn", 14.25F);
            this.selecteduser.ForeColor = System.Drawing.Color.White;
            this.selecteduser.Location = new System.Drawing.Point(7, 7);
            this.selecteduser.Name = "selecteduser";
            this.selecteduser.Size = new System.Drawing.Size(156, 23);
            this.selecteduser.TabIndex = 1;
            this.selecteduser.Text = "Utilisateur : (Global)";
            this.selecteduser.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.startproc);
            this.panel1.Controls.Add(this.shutdown);
            this.panel1.Controls.Add(this.selecteduser);
            this.panel1.Location = new System.Drawing.Point(571, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 601);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // shutdown
            // 
            this.shutdown.Location = new System.Drawing.Point(12, 47);
            this.shutdown.Name = "shutdown";
            this.shutdown.Size = new System.Drawing.Size(147, 23);
            this.shutdown.TabIndex = 2;
            this.shutdown.Text = "Eteindre PC";
            this.shutdown.UseVisualStyleBackColor = true;
            this.shutdown.Click += new System.EventHandler(this.button1_Click);
            // 
            // startproc
            // 
            this.startproc.Location = new System.Drawing.Point(2, 416);
            this.startproc.Name = "startproc";
            this.startproc.Size = new System.Drawing.Size(678, 23);
            this.startproc.TabIndex = 3;
            this.startproc.Text = "Démarrer processus";
            this.startproc.UseVisualStyleBackColor = true;
            this.startproc.Click += new System.EventHandler(this.startproc_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Roboto Cn", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(2, 385);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(678, 31);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.DetectUrls = false;
            this.richTextBox1.Font = new System.Drawing.Font("Roboto Cn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Cyan;
            this.richTextBox1.Location = new System.Drawing.Point(2, 440);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(678, 160);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "YTAH V1.0 - By Nextrie";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROJET YTAH";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader pc_id_column;
        private System.Windows.Forms.ColumnHeader user_column;
        private System.Windows.Forms.ColumnHeader isadmin_column;
        private System.Windows.Forms.ColumnHeader ipadress_column;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label selecteduser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button shutdown;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button startproc;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

