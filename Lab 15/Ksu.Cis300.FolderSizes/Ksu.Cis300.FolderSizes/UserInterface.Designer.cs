namespace Ksu.Cis300.FolderSizes
{
    partial class UserInterface
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
            this.uxUp = new System.Windows.Forms.Button();
            this.uxFolderList = new System.Windows.Forms.ListBox();
            this.uxSize = new System.Windows.Forms.TextBox();
            this.uxSizeLabel = new System.Windows.Forms.Label();
            this.uxCurrentFolder = new System.Windows.Forms.TextBox();
            this.uxSetFolder = new System.Windows.Forms.Button();
            this.uxFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.uxSubFoldersLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxUp
            // 
            this.uxUp.Enabled = false;
            this.uxUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxUp.Location = new System.Drawing.Point(20, 379);
            this.uxUp.Name = "uxUp";
            this.uxUp.Size = new System.Drawing.Size(357, 41);
            this.uxUp.TabIndex = 26;
            this.uxUp.Text = "Up one level";
            this.uxUp.UseVisualStyleBackColor = true;
            this.uxUp.Click += new System.EventHandler(this.uxUp_Click);
            // 
            // uxFolderList
            // 
            this.uxFolderList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFolderList.FormattingEnabled = true;
            this.uxFolderList.ItemHeight = 24;
            this.uxFolderList.Location = new System.Drawing.Point(20, 129);
            this.uxFolderList.Name = "uxFolderList";
            this.uxFolderList.Size = new System.Drawing.Size(356, 244);
            this.uxFolderList.TabIndex = 25;
            this.uxFolderList.SelectedIndexChanged += new System.EventHandler(this.uxFolderList_SelectedIndexChanged);
            // 
            // uxSize
            // 
            this.uxSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSize.Location = new System.Drawing.Point(185, 59);
            this.uxSize.Name = "uxSize";
            this.uxSize.ReadOnly = true;
            this.uxSize.Size = new System.Drawing.Size(192, 29);
            this.uxSize.TabIndex = 24;
            this.uxSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // uxSizeLabel
            // 
            this.uxSizeLabel.AutoSize = true;
            this.uxSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSizeLabel.Location = new System.Drawing.Point(16, 62);
            this.uxSizeLabel.Name = "uxSizeLabel";
            this.uxSizeLabel.Size = new System.Drawing.Size(163, 24);
            this.uxSizeLabel.TabIndex = 23;
            this.uxSizeLabel.Text = "Total size in bytes:";
            // 
            // uxCurrentFolder
            // 
            this.uxCurrentFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCurrentFolder.Location = new System.Drawing.Point(108, 23);
            this.uxCurrentFolder.Name = "uxCurrentFolder";
            this.uxCurrentFolder.ReadOnly = true;
            this.uxCurrentFolder.Size = new System.Drawing.Size(268, 29);
            this.uxCurrentFolder.TabIndex = 22;
            // 
            // uxSetFolder
            // 
            this.uxSetFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSetFolder.Location = new System.Drawing.Point(20, 18);
            this.uxSetFolder.Name = "uxSetFolder";
            this.uxSetFolder.Size = new System.Drawing.Size(82, 41);
            this.uxSetFolder.TabIndex = 21;
            this.uxSetFolder.Text = "Folder:";
            this.uxSetFolder.UseVisualStyleBackColor = true;
            this.uxSetFolder.Click += new System.EventHandler(this.uxSetFolder_Click);
            // 
            // uxSubFoldersLabel
            // 
            this.uxSubFoldersLabel.AutoSize = true;
            this.uxSubFoldersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSubFoldersLabel.Location = new System.Drawing.Point(16, 102);
            this.uxSubFoldersLabel.Name = "uxSubFoldersLabel";
            this.uxSubFoldersLabel.Size = new System.Drawing.Size(111, 24);
            this.uxSubFoldersLabel.TabIndex = 27;
            this.uxSubFoldersLabel.Text = "Sub-folders:";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 438);
            this.Controls.Add(this.uxUp);
            this.Controls.Add(this.uxFolderList);
            this.Controls.Add(this.uxSize);
            this.Controls.Add(this.uxSizeLabel);
            this.Controls.Add(this.uxCurrentFolder);
            this.Controls.Add(this.uxSetFolder);
            this.Controls.Add(this.uxSubFoldersLabel);
            this.Name = "UserInterface";
            this.Text = "File System Analyzer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxUp;
        private System.Windows.Forms.ListBox uxFolderList;
        private System.Windows.Forms.TextBox uxSize;
        private System.Windows.Forms.Label uxSizeLabel;
        private System.Windows.Forms.TextBox uxCurrentFolder;
        private System.Windows.Forms.Button uxSetFolder;
        private System.Windows.Forms.FolderBrowserDialog uxFolderBrowser;
        private System.Windows.Forms.Label uxSubFoldersLabel;
    }
}

