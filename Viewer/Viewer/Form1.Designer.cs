namespace Viewer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.conct = new System.Windows.Forms.Button();
            this.passwordInp = new System.Windows.Forms.TextBox();
            this.userInp = new System.Windows.Forms.TextBox();
            this.databaseInp = new System.Windows.Forms.TextBox();
            this.serverInp = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.request = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.vent = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.keyword = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.refresh = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.authorGallery1 = new Viewer.AuthorGallery();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // conct
            // 
            this.conct.BackColor = System.Drawing.SystemColors.ControlDark;
            this.conct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.conct.Location = new System.Drawing.Point(468, 27);
            this.conct.Name = "conct";
            this.conct.Size = new System.Drawing.Size(129, 47);
            this.conct.TabIndex = 5;
            this.conct.Text = "Connect";
            this.conct.UseVisualStyleBackColor = false;
            this.conct.Click += new System.EventHandler(this.conct_Click);
            // 
            // passwordInp
            // 
            this.passwordInp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordInp.Location = new System.Drawing.Point(307, 54);
            this.passwordInp.Name = "passwordInp";
            this.passwordInp.PasswordChar = '•';
            this.passwordInp.Size = new System.Drawing.Size(137, 20);
            this.passwordInp.TabIndex = 4;
            // 
            // userInp
            // 
            this.userInp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userInp.Location = new System.Drawing.Point(307, 29);
            this.userInp.Name = "userInp";
            this.userInp.Size = new System.Drawing.Size(137, 20);
            this.userInp.TabIndex = 3;
            // 
            // databaseInp
            // 
            this.databaseInp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.databaseInp.Location = new System.Drawing.Point(101, 54);
            this.databaseInp.Name = "databaseInp";
            this.databaseInp.Size = new System.Drawing.Size(137, 20);
            this.databaseInp.TabIndex = 2;
            // 
            // serverInp
            // 
            this.serverInp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serverInp.Location = new System.Drawing.Point(101, 29);
            this.serverInp.Name = "serverInp";
            this.serverInp.Size = new System.Drawing.Size(137, 20);
            this.serverInp.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(243, 57);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 13);
            this.label18.TabIndex = 130;
            this.label18.Text = "Password :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(241, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 129;
            this.label17.Text = "Username :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 13);
            this.label16.TabIndex = 128;
            this.label16.Text = "Database Name :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 13);
            this.label15.TabIndex = 127;
            this.label15.Text = "Server Address :";
            // 
            // request
            // 
            this.request.Enabled = false;
            this.request.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.request.Location = new System.Drawing.Point(166, 567);
            this.request.Name = "request";
            this.request.Size = new System.Drawing.Size(278, 23);
            this.request.TabIndex = 9;
            this.request.Text = "REQUEST";
            this.request.UseVisualStyleBackColor = true;
            this.request.Click += new System.EventHandler(this.request_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(166, 173);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(278, 23);
            this.progressBar1.TabIndex = 125;
            this.progressBar1.UseWaitCursor = true;
            this.progressBar1.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(228, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 119;
            this.label9.Text = ":";
            // 
            // search
            // 
            this.search.Enabled = false;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Location = new System.Drawing.Point(166, 173);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(278, 23);
            this.search.TabIndex = 8;
            this.search.Text = "SEARCH";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // vent
            // 
            this.vent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.vent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.vent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vent.Enabled = false;
            this.vent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vent.Location = new System.Drawing.Point(244, 121);
            this.vent.Name = "vent";
            this.vent.Size = new System.Drawing.Size(200, 21);
            this.vent.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 103;
            this.label2.Text = "Event";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(616, 24);
            this.menuStrip1.TabIndex = 101;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentationToolStripMenuItem,
            this.creditToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // documentationToolStripMenuItem
            // 
            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            this.documentationToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.documentationToolStripMenuItem.Text = "&Documentation";
            // 
            // creditToolStripMenuItem
            // 
            this.creditToolStripMenuItem.Name = "creditToolStripMenuItem";
            this.creditToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.creditToolStripMenuItem.Text = "&Credit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 137;
            this.label3.Text = "Keywords";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 138;
            this.label4.Text = ":";
            // 
            // keyword
            // 
            this.keyword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyword.Enabled = false;
            this.keyword.Location = new System.Drawing.Point(244, 147);
            this.keyword.Name = "keyword";
            this.keyword.Size = new System.Drawing.Size(200, 20);
            this.keyword.TabIndex = 7;
            // 
            // refresh
            // 
            this.refresh.Enabled = false;
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Location = new System.Drawing.Point(450, 121);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(58, 75);
            this.refresh.TabIndex = 10;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(243, 206);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(22, 13);
            this.time.TabIndex = 141;
            this.time.Text = "0.0";
            this.time.Visible = false;
            // 
            // authorGallery1
            // 
            this.authorGallery1.AutoScroll = true;
            this.authorGallery1.Location = new System.Drawing.Point(13, 222);
            this.authorGallery1.Name = "authorGallery1";
            this.authorGallery1.Size = new System.Drawing.Size(591, 324);
            this.authorGallery1.TabIndex = 136;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 594);
            this.Controls.Add(this.time);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.keyword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.authorGallery1);
            this.Controls.Add(this.conct);
            this.Controls.Add(this.passwordInp);
            this.Controls.Add(this.userInp);
            this.Controls.Add(this.databaseInp);
            this.Controls.Add(this.serverInp);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.request);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.search);
            this.Controls.Add(this.vent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "LAI Gallery Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button conct;
        private System.Windows.Forms.TextBox passwordInp;
        private System.Windows.Forms.TextBox userInp;
        private System.Windows.Forms.TextBox databaseInp;
        private System.Windows.Forms.TextBox serverInp;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button request;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ComboBox vent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditToolStripMenuItem;
        private AuthorGallery authorGallery1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox keyword;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Label time;
    }
}

