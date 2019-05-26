namespace BlogEngineMigrator
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
            this.btMigrate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbProviderSelection = new System.Windows.Forms.GroupBox();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.gbIISServer = new System.Windows.Forms.GroupBox();
            this.lbl = new System.Windows.Forms.Label();
            this.tbFolder = new System.Windows.Forms.TextBox();
            this.btnPickFolder = new System.Windows.Forms.Button();
            this.gbSQLServer = new System.Windows.Forms.GroupBox();
            this.btnPickSQL = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tbSQL = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.gbProviderSelection.SuspendLayout();
            this.gbIISServer.SuspendLayout();
            this.gbSQLServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btMigrate
            // 
            this.btMigrate.Location = new System.Drawing.Point(28, 269);
            this.btMigrate.Name = "btMigrate";
            this.btMigrate.Size = new System.Drawing.Size(122, 41);
            this.btMigrate.TabIndex = 0;
            this.btMigrate.Text = "Migrate";
            this.btMigrate.UseVisualStyleBackColor = true;
            this.btMigrate.Click += new System.EventHandler(this.btMigrate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(775, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // gbProviderSelection
            // 
            this.gbProviderSelection.Controls.Add(this.cbTo);
            this.gbProviderSelection.Controls.Add(this.cbFrom);
            this.gbProviderSelection.Controls.Add(this.lblTo);
            this.gbProviderSelection.Controls.Add(this.lblFrom);
            this.gbProviderSelection.Location = new System.Drawing.Point(12, 137);
            this.gbProviderSelection.Name = "gbProviderSelection";
            this.gbProviderSelection.Size = new System.Drawing.Size(364, 71);
            this.gbProviderSelection.TabIndex = 6;
            this.gbProviderSelection.TabStop = false;
            this.gbProviderSelection.Text = "Provider Selection";
            // 
            // cbTo
            // 
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Items.AddRange(new object[] {
            "DBProvider",
            "XmlProvider"});
            this.cbTo.Location = new System.Drawing.Point(226, 27);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(121, 21);
            this.cbTo.TabIndex = 8;
            // 
            // cbFrom
            // 
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Items.AddRange(new object[] {
            "XmlProvider",
            "DBProvider"});
            this.cbFrom.Location = new System.Drawing.Point(57, 27);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(121, 21);
            this.cbFrom.TabIndex = 7;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(197, 30);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(23, 13);
            this.lblTo.TabIndex = 6;
            this.lblTo.Text = "To:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(18, 30);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(33, 13);
            this.lblFrom.TabIndex = 5;
            this.lblFrom.Text = "From:";
            // 
            // gbIISServer
            // 
            this.gbIISServer.Controls.Add(this.lbl);
            this.gbIISServer.Controls.Add(this.tbFolder);
            this.gbIISServer.Controls.Add(this.btnPickFolder);
            this.gbIISServer.Location = new System.Drawing.Point(12, 27);
            this.gbIISServer.Name = "gbIISServer";
            this.gbIISServer.Size = new System.Drawing.Size(364, 94);
            this.gbIISServer.TabIndex = 7;
            this.gbIISServer.TabStop = false;
            this.gbIISServer.Text = "IIS Server Details";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(6, 28);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(127, 13);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "Select Web Site location:";
            // 
            // tbFolder
            // 
            this.tbFolder.Location = new System.Drawing.Point(6, 54);
            this.tbFolder.Name = "tbFolder";
            this.tbFolder.Size = new System.Drawing.Size(260, 20);
            this.tbFolder.TabIndex = 1;
            this.tbFolder.Text = "C:\\inetpub\\wwwroot";
            // 
            // btnPickFolder
            // 
            this.btnPickFolder.Location = new System.Drawing.Point(272, 52);
            this.btnPickFolder.Name = "btnPickFolder";
            this.btnPickFolder.Size = new System.Drawing.Size(75, 23);
            this.btnPickFolder.TabIndex = 0;
            this.btnPickFolder.Text = "Pick Folder";
            this.btnPickFolder.UseVisualStyleBackColor = true;
            this.btnPickFolder.Click += new System.EventHandler(this.btnPickFolder_Click);
            // 
            // gbSQLServer
            // 
            this.gbSQLServer.Controls.Add(this.tbSQL);
            this.gbSQLServer.Controls.Add(this.btnPickSQL);
            this.gbSQLServer.Location = new System.Drawing.Point(382, 27);
            this.gbSQLServer.Name = "gbSQLServer";
            this.gbSQLServer.Size = new System.Drawing.Size(381, 94);
            this.gbSQLServer.TabIndex = 8;
            this.gbSQLServer.TabStop = false;
            this.gbSQLServer.Text = "SQL Server Details";
            // 
            // btnPickSQL
            // 
            this.btnPickSQL.Location = new System.Drawing.Point(272, 50);
            this.btnPickSQL.Name = "btnPickSQL";
            this.btnPickSQL.Size = new System.Drawing.Size(75, 23);
            this.btnPickSQL.TabIndex = 0;
            this.btnPickSQL.Text = "Pick SQL Server";
            this.btnPickSQL.UseVisualStyleBackColor = true;
            this.btnPickSQL.Click += new System.EventHandler(this.btnPickSQL_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // tbSQL
            // 
            this.tbSQL.Location = new System.Drawing.Point(6, 52);
            this.tbSQL.Name = "tbSQL";
            this.tbSQL.Size = new System.Drawing.Size(260, 20);
            this.tbSQL.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 334);
            this.Controls.Add(this.gbSQLServer);
            this.Controls.Add(this.gbIISServer);
            this.Controls.Add(this.gbProviderSelection);
            this.Controls.Add(this.btMigrate);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "BlogEngine.NET Migrator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbProviderSelection.ResumeLayout(false);
            this.gbProviderSelection.PerformLayout();
            this.gbIISServer.ResumeLayout(false);
            this.gbIISServer.PerformLayout();
            this.gbSQLServer.ResumeLayout(false);
            this.gbSQLServer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btMigrate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbProviderSelection;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.GroupBox gbIISServer;
        private System.Windows.Forms.GroupBox gbSQLServer;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox tbFolder;
        private System.Windows.Forms.Button btnPickFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnPickSQL;
        private System.Windows.Forms.TextBox tbSQL;
    }
}

