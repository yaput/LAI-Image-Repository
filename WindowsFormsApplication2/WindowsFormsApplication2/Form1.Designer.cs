namespace WindowsFormsApplication2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.save = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.index = new System.Windows.Forms.Button();
            this.browse = new System.Windows.Forms.Button();
            this.folder = new System.Windows.Forms.TextBox();
            this.tag = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fotografer = new System.Windows.Forms.ComboBox();
            this.lokasi = new System.Windows.Forms.ComboBox();
            this.vent = new System.Windows.Forms.ComboBox();
            this.program = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.serverInp = new System.Windows.Forms.TextBox();
            this.databaseInp = new System.Windows.Forms.TextBox();
            this.userInp = new System.Windows.Forms.TextBox();
            this.passwordInp = new System.Windows.Forms.TextBox();
            this.conct = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.authorCodeImageGalleryVB1 = new WindowsFormsApplication2.AuthorCodeImageGalleryVB();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewerToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(609, 24);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewerToolStripMenuItem
            // 
            this.viewerToolStripMenuItem.Name = "viewerToolStripMenuItem";
            this.viewerToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.viewerToolStripMenuItem.Text = "Viewer";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentationToolStripMenuItem,
            this.creditsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // documentationToolStripMenuItem
            // 
            this.documentationToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            this.documentationToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.documentationToolStripMenuItem.Text = "Documentation";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.creditsToolStripMenuItem.Text = "Credits";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(140)))));
            this.save.Enabled = false;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Location = new System.Drawing.Point(166, 563);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(278, 23);
            this.save.TabIndex = 14;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.progressBar1.Location = new System.Drawing.Point(166, 268);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(278, 23);
            this.progressBar1.TabIndex = 90;
            this.progressBar1.UseWaitCursor = true;
            this.progressBar1.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.label14.Location = new System.Drawing.Point(228, 244);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(10, 13);
            this.label14.TabIndex = 89;
            this.label14.Text = ":";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.label13.Location = new System.Drawing.Point(228, 217);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 13);
            this.label13.TabIndex = 88;
            this.label13.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.label12.Location = new System.Drawing.Point(228, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 13);
            this.label12.TabIndex = 87;
            this.label12.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.label11.Location = new System.Drawing.Point(228, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 86;
            this.label11.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.label10.Location = new System.Drawing.Point(228, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 85;
            this.label10.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.label9.Location = new System.Drawing.Point(228, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 84;
            this.label9.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.label8.Location = new System.Drawing.Point(228, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 83;
            this.label8.Text = ":";
            // 
            // index
            // 
            this.index.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(140)))));
            this.index.Enabled = false;
            this.index.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.index.Location = new System.Drawing.Point(166, 268);
            this.index.Name = "index";
            this.index.Size = new System.Drawing.Size(278, 23);
            this.index.TabIndex = 13;
            this.index.Text = "INDEXING";
            this.index.UseVisualStyleBackColor = false;
            this.index.Click += new System.EventHandler(this.index_Click);
            // 
            // browse
            // 
            this.browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(140)))));
            this.browse.Enabled = false;
            this.browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browse.Location = new System.Drawing.Point(383, 239);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(61, 23);
            this.browse.TabIndex = 12;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = false;
            this.browse.Click += new System.EventHandler(this.browse_Click_1);
            // 
            // folder
            // 
            this.folder.BackColor = System.Drawing.SystemColors.Menu;
            this.folder.Enabled = false;
            this.folder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.folder.Location = new System.Drawing.Point(244, 241);
            this.folder.Name = "folder";
            this.folder.ReadOnly = true;
            this.folder.Size = new System.Drawing.Size(133, 20);
            this.folder.TabIndex = 79;
            // 
            // tag
            // 
            this.tag.BackColor = System.Drawing.SystemColors.Menu;
            this.tag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tag.Enabled = false;
            this.tag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.tag.Location = new System.Drawing.Point(244, 215);
            this.tag.Name = "tag";
            this.tag.Size = new System.Drawing.Size(200, 20);
            this.tag.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(244, 194);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.label7.Location = new System.Drawing.Point(163, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 76;
            this.label7.Text = "Folder";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.label6.Location = new System.Drawing.Point(163, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 75;
            this.label6.Text = "Tag";
            // 
            // fotografer
            // 
            this.fotografer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.fotografer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.fotografer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fotografer.Enabled = false;
            this.fotografer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fotografer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.fotografer.FormattingEnabled = true;
            this.fotografer.Location = new System.Drawing.Point(244, 171);
            this.fotografer.Name = "fotografer";
            this.fotografer.Size = new System.Drawing.Size(200, 21);
            this.fotografer.TabIndex = 9;
            // 
            // lokasi
            // 
            this.lokasi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lokasi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lokasi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lokasi.Enabled = false;
            this.lokasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lokasi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.lokasi.FormattingEnabled = true;
            this.lokasi.Location = new System.Drawing.Point(244, 144);
            this.lokasi.Name = "lokasi";
            this.lokasi.Size = new System.Drawing.Size(200, 21);
            this.lokasi.TabIndex = 8;
            // 
            // vent
            // 
            this.vent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.vent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.vent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.vent.Enabled = false;
            this.vent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.vent.FormattingEnabled = true;
            this.vent.Location = new System.Drawing.Point(244, 117);
            this.vent.Name = "vent";
            this.vent.Size = new System.Drawing.Size(200, 21);
            this.vent.TabIndex = 7;
            // 
            // program
            // 
            this.program.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.program.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.program.BackColor = System.Drawing.SystemColors.ControlLight;
            this.program.Enabled = false;
            this.program.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.program.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.program.FormattingEnabled = true;
            this.program.Location = new System.Drawing.Point(244, 89);
            this.program.Name = "program";
            this.program.Size = new System.Drawing.Size(200, 21);
            this.program.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.label5.Location = new System.Drawing.Point(163, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 70;
            this.label5.Text = "Tanggal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.label4.Location = new System.Drawing.Point(163, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "Fotografer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.label3.Location = new System.Drawing.Point(163, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Lokasi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.label2.Location = new System.Drawing.Point(163, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Event";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.label1.Location = new System.Drawing.Point(163, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Program";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.label15.Location = new System.Drawing.Point(10, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 13);
            this.label15.TabIndex = 92;
            this.label15.Text = "Server Address";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.label16.Location = new System.Drawing.Point(10, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 13);
            this.label16.TabIndex = 93;
            this.label16.Text = "Database Name :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.label17.Location = new System.Drawing.Point(241, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 94;
            this.label17.Text = "Username :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.label18.Location = new System.Drawing.Point(243, 53);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 13);
            this.label18.TabIndex = 95;
            this.label18.Text = "Password :";
            // 
            // serverInp
            // 
            this.serverInp.BackColor = System.Drawing.SystemColors.Menu;
            this.serverInp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serverInp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.serverInp.Location = new System.Drawing.Point(101, 25);
            this.serverInp.Name = "serverInp";
            this.serverInp.Size = new System.Drawing.Size(137, 20);
            this.serverInp.TabIndex = 1;
            // 
            // databaseInp
            // 
            this.databaseInp.BackColor = System.Drawing.SystemColors.Menu;
            this.databaseInp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.databaseInp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.databaseInp.Location = new System.Drawing.Point(101, 50);
            this.databaseInp.Name = "databaseInp";
            this.databaseInp.Size = new System.Drawing.Size(137, 20);
            this.databaseInp.TabIndex = 2;
            // 
            // userInp
            // 
            this.userInp.BackColor = System.Drawing.SystemColors.Menu;
            this.userInp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userInp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.userInp.Location = new System.Drawing.Point(307, 25);
            this.userInp.Name = "userInp";
            this.userInp.Size = new System.Drawing.Size(137, 20);
            this.userInp.TabIndex = 3;
            // 
            // passwordInp
            // 
            this.passwordInp.BackColor = System.Drawing.SystemColors.Menu;
            this.passwordInp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordInp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.passwordInp.Location = new System.Drawing.Point(307, 50);
            this.passwordInp.Name = "passwordInp";
            this.passwordInp.PasswordChar = '•';
            this.passwordInp.Size = new System.Drawing.Size(137, 20);
            this.passwordInp.TabIndex = 4;
            // 
            // conct
            // 
            this.conct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(117)))), ((int)(((byte)(140)))));
            this.conct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.conct.Location = new System.Drawing.Point(468, 25);
            this.conct.Name = "conct";
            this.conct.Size = new System.Drawing.Size(129, 47);
            this.conct.TabIndex = 5;
            this.conct.Text = "Connect";
            this.conct.UseVisualStyleBackColor = false;
            this.conct.Click += new System.EventHandler(this.conct_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.time.Location = new System.Drawing.Point(243, 294);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(41, 13);
            this.time.TabIndex = 101;
            this.time.Text = "label19";
            this.time.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(90, 28);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(10, 13);
            this.label19.TabIndex = 102;
            this.label19.Text = ":";
            this.label19.Visible = false;
            // 
            // authorCodeImageGalleryVB1
            // 
            this.authorCodeImageGalleryVB1.AutoScroll = true;
            this.authorCodeImageGalleryVB1.Directorypath = null;
            this.authorCodeImageGalleryVB1.Location = new System.Drawing.Point(13, 310);
            this.authorCodeImageGalleryVB1.Name = "authorCodeImageGalleryVB1";
            this.authorCodeImageGalleryVB1.Size = new System.Drawing.Size(585, 241);
            this.authorCodeImageGalleryVB1.TabIndex = 82;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(609, 608);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.time);
            this.Controls.Add(this.conct);
            this.Controls.Add(this.passwordInp);
            this.Controls.Add(this.userInp);
            this.Controls.Add(this.databaseInp);
            this.Controls.Add(this.serverInp);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.save);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.authorCodeImageGalleryVB1);
            this.Controls.Add(this.index);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.folder);
            this.Controls.Add(this.tag);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fotografer);
            this.Controls.Add(this.lokasi);
            this.Controls.Add(this.vent);
            this.Controls.Add(this.program);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(63)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(625, 646);
            this.MinimumSize = new System.Drawing.Size(625, 646);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Index";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private AuthorCodeImageGalleryVB authorCodeImageGalleryVB1;
        private System.Windows.Forms.Button index;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.TextBox folder;
        private System.Windows.Forms.TextBox tag;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox fotografer;
        private System.Windows.Forms.ComboBox lokasi;
        private System.Windows.Forms.ComboBox vent;
        private System.Windows.Forms.ComboBox program;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox serverInp;
        private System.Windows.Forms.TextBox databaseInp;
        private System.Windows.Forms.TextBox userInp;
        private System.Windows.Forms.TextBox passwordInp;
        private System.Windows.Forms.Button conct;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.ToolStripMenuItem viewerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.Label label19;

    }
}

