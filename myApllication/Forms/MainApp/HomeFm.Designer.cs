namespace myApllication.Forms.MainApp
{
    partial class HomeFm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.folderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewDownloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mehrCodeLandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instagramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.folderToolStripMenuItem,
            this.mehrCodeLandToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // folderToolStripMenuItem
            // 
            this.folderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewDownloadToolStripMenuItem,
            this.importFromFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.folderToolStripMenuItem.Name = "folderToolStripMenuItem";
            this.folderToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.folderToolStripMenuItem.Text = "Folder";
            // 
            // createNewDownloadToolStripMenuItem
            // 
            this.createNewDownloadToolStripMenuItem.Name = "createNewDownloadToolStripMenuItem";
            this.createNewDownloadToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.createNewDownloadToolStripMenuItem.Text = "Create New Download";
            // 
            // importFromFileToolStripMenuItem
            // 
            this.importFromFileToolStripMenuItem.Name = "importFromFileToolStripMenuItem";
            this.importFromFileToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.importFromFileToolStripMenuItem.Text = "Import From File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mehrCodeLandToolStripMenuItem
            // 
            this.mehrCodeLandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.githubToolStripMenuItem,
            this.instagramToolStripMenuItem,
            this.twitterToolStripMenuItem});
            this.mehrCodeLandToolStripMenuItem.Name = "mehrCodeLandToolStripMenuItem";
            this.mehrCodeLandToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mehrCodeLandToolStripMenuItem.Text = "MehrCodeLand";
            // 
            // githubToolStripMenuItem
            // 
            this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            this.githubToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.githubToolStripMenuItem.Text = "Github";
            this.githubToolStripMenuItem.Click += new System.EventHandler(this.githubToolStripMenuItem_Click);
            // 
            // instagramToolStripMenuItem
            // 
            this.instagramToolStripMenuItem.Name = "instagramToolStripMenuItem";
            this.instagramToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.instagramToolStripMenuItem.Text = "Instagram";
            // 
            // twitterToolStripMenuItem
            // 
            this.twitterToolStripMenuItem.Name = "twitterToolStripMenuItem";
            this.twitterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.twitterToolStripMenuItem.Text = "Twitter";
            // 
            // HomeFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeFm";
            this.Text = "HomeFm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem folderToolStripMenuItem;
        private ToolStripMenuItem createNewDownloadToolStripMenuItem;
        private ToolStripMenuItem importFromFileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem mehrCodeLandToolStripMenuItem;
        private ToolStripMenuItem githubToolStripMenuItem;
        private ToolStripMenuItem instagramToolStripMenuItem;
        private ToolStripMenuItem twitterToolStripMenuItem;
    }
}