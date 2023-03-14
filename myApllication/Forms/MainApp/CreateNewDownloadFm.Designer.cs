namespace myApllication.Forms.MainApp
{
    partial class CreateNewDownloadFm
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
            this.downloadTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PathtextBox = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DownloadLattercBxo = new System.Windows.Forms.CheckBox();
            this.ConectionsUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConectionsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // downloadTextbox
            // 
            this.downloadTextbox.Location = new System.Drawing.Point(168, 54);
            this.downloadTextbox.Name = "downloadTextbox";
            this.downloadTextbox.Size = new System.Drawing.Size(578, 23);
            this.downloadTextbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Download Link";
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(323, 343);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(167, 34);
            this.StartBtn.TabIndex = 2;
            this.StartBtn.Text = "Add To Download List";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Path To Save :";
            // 
            // PathtextBox
            // 
            this.PathtextBox.Location = new System.Drawing.Point(168, 93);
            this.PathtextBox.Name = "PathtextBox";
            this.PathtextBox.Size = new System.Drawing.Size(497, 23);
            this.PathtextBox.TabIndex = 4;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(671, 92);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 5;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.timeBox);
            this.groupBox1.Controls.Add(this.dateBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DownloadLattercBxo);
            this.groupBox1.Controls.Add(this.ConectionsUpDown);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(100, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 189);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // timeBox
            // 
            this.timeBox.Enabled = false;
            this.timeBox.Location = new System.Drawing.Point(348, 82);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(183, 23);
            this.timeBox.TabIndex = 12;
            // 
            // dateBox
            // 
            this.dateBox.Enabled = false;
            this.dateBox.Location = new System.Drawing.Point(97, 82);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(183, 23);
            this.dateBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date";
            // 
            // DownloadLattercBxo
            // 
            this.DownloadLattercBxo.AutoSize = true;
            this.DownloadLattercBxo.Location = new System.Drawing.Point(348, 37);
            this.DownloadLattercBxo.Name = "DownloadLattercBxo";
            this.DownloadLattercBxo.Size = new System.Drawing.Size(107, 19);
            this.DownloadLattercBxo.TabIndex = 9;
            this.DownloadLattercBxo.Text = "Dowload Latter";
            this.DownloadLattercBxo.UseVisualStyleBackColor = true;
            this.DownloadLattercBxo.CheckedChanged += new System.EventHandler(this.DownloadLattercBxo_CheckedChanged);
            // 
            // ConectionsUpDown
            // 
            this.ConectionsUpDown.Location = new System.Drawing.Point(97, 33);
            this.ConectionsUpDown.Name = "ConectionsUpDown";
            this.ConectionsUpDown.Size = new System.Drawing.Size(183, 23);
            this.ConectionsUpDown.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Connections:";
            // 
            // CreateNewDownloadFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.PathtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.downloadTextbox);
            this.Name = "CreateNewDownloadFm";
            this.ShowInTaskbar = false;
            this.Text = "Create New Download";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConectionsUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox downloadTextbox;
        private Label label1;
        private Button StartBtn;
        private Label label2;
        private TextBox PathtextBox;
        private Button SearchBtn;
        private GroupBox groupBox1;
        private TextBox timeBox;
        private TextBox dateBox;
        private Label label5;
        private Label label4;
        private CheckBox DownloadLattercBxo;
        private NumericUpDown ConectionsUpDown;
        private Label label3;
    }
}