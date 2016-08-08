namespace TClean
{
    partial class TClean
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TClean));
            this.Lista = new System.Windows.Forms.ListBox();
            this.Analyze = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Clean = new System.Windows.Forms.Button();
            this.TargetBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Change = new System.Windows.Forms.Button();
            this.Selector = new System.Windows.Forms.FolderBrowserDialog();
            this.TorrentCB = new System.Windows.Forms.CheckBox();
            this.OwnextCB = new System.Windows.Forms.CheckBox();
            this.OwnextTB = new System.Windows.Forms.TextBox();
            this.ExtensionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lista
            // 
            this.Lista.FormattingEnabled = true;
            this.Lista.Items.AddRange(new object[] {
            "Ready"});
            this.Lista.Location = new System.Drawing.Point(12, 108);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(593, 134);
            this.Lista.TabIndex = 0;
            // 
            // Analyze
            // 
            this.Analyze.Location = new System.Drawing.Point(515, 16);
            this.Analyze.Name = "Analyze";
            this.Analyze.Size = new System.Drawing.Size(90, 35);
            this.Analyze.TabIndex = 1;
            this.Analyze.Text = "Analyze";
            this.Analyze.UseVisualStyleBackColor = true;
            this.Analyze.Click += new System.EventHandler(this.Analyze_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Target:";
            // 
            // Clean
            // 
            this.Clean.Location = new System.Drawing.Point(515, 57);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(90, 38);
            this.Clean.TabIndex = 3;
            this.Clean.Text = "Clean";
            this.Clean.UseVisualStyleBackColor = true;
            this.Clean.Click += new System.EventHandler(this.Clean_Click);
            // 
            // TargetBox
            // 
            this.TargetBox.Location = new System.Drawing.Point(56, 31);
            this.TargetBox.Name = "TargetBox";
            this.TargetBox.Size = new System.Drawing.Size(369, 20);
            this.TargetBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Status:";
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(431, 24);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(75, 33);
            this.Change.TabIndex = 6;
            this.Change.Text = "Change";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Selector
            // 
            this.Selector.Description = "Select the target folder where .torrent files found.";
            this.Selector.ShowNewFolderButton = false;
            // 
            // TorrentCB
            // 
            this.TorrentCB.AutoSize = true;
            this.TorrentCB.Checked = true;
            this.TorrentCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TorrentCB.Location = new System.Drawing.Point(56, 67);
            this.TorrentCB.Name = "TorrentCB";
            this.TorrentCB.Size = new System.Drawing.Size(59, 17);
            this.TorrentCB.TabIndex = 8;
            this.TorrentCB.Text = ".torrent";
            this.TorrentCB.UseVisualStyleBackColor = true;
            // 
            // OwnextCB
            // 
            this.OwnextCB.AutoSize = true;
            this.OwnextCB.Location = new System.Drawing.Point(121, 67);
            this.OwnextCB.Name = "OwnextCB";
            this.OwnextCB.Size = new System.Drawing.Size(15, 14);
            this.OwnextCB.TabIndex = 9;
            this.OwnextCB.UseVisualStyleBackColor = true;
            // 
            // OwnextTB
            // 
            this.OwnextTB.Location = new System.Drawing.Point(142, 65);
            this.OwnextTB.MaxLength = 20;
            this.OwnextTB.Name = "OwnextTB";
            this.OwnextTB.Size = new System.Drawing.Size(100, 20);
            this.OwnextTB.TabIndex = 10;
            this.OwnextTB.Text = ".exe";
            // 
            // ExtensionLabel
            // 
            this.ExtensionLabel.AutoSize = true;
            this.ExtensionLabel.Location = new System.Drawing.Point(12, 71);
            this.ExtensionLabel.Name = "ExtensionLabel";
            this.ExtensionLabel.Size = new System.Drawing.Size(25, 13);
            this.ExtensionLabel.TabIndex = 11;
            this.ExtensionLabel.Text = "Ext:";
            // 
            // TClean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 273);
            this.Controls.Add(this.ExtensionLabel);
            this.Controls.Add(this.OwnextTB);
            this.Controls.Add(this.OwnextCB);
            this.Controls.Add(this.TorrentCB);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TargetBox);
            this.Controls.Add(this.Clean);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Analyze);
            this.Controls.Add(this.Lista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TClean";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TClean";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lista;
        private System.Windows.Forms.Button Analyze;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Clean;
        private System.Windows.Forms.TextBox TargetBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.FolderBrowserDialog Selector;
        private System.Windows.Forms.CheckBox TorrentCB;
        private System.Windows.Forms.CheckBox OwnextCB;
        private System.Windows.Forms.TextBox OwnextTB;
        private System.Windows.Forms.Label ExtensionLabel;
    }
}

