namespace Ksu.Cis300.Boggle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterface));
            this.uxWordsFound = new System.Windows.Forms.ListBox();
            this.uxWordsFoundLabel = new System.Windows.Forms.Label();
            this.uxOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxMenuBar = new System.Windows.Forms.ToolStrip();
            this.uxNewBoard = new System.Windows.Forms.ToolStripButton();
            this.uxFindWords = new System.Windows.Forms.ToolStripButton();
            this.uxBoardContainer = new System.Windows.Forms.Panel();
            this.uxBoard = new System.Windows.Forms.DataGridView();
            this.Column0 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.uxMenuBar.SuspendLayout();
            this.uxBoardContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // uxWordsFound
            // 
            this.uxWordsFound.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxWordsFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxWordsFound.FormattingEnabled = true;
            this.uxWordsFound.ItemHeight = 24;
            this.uxWordsFound.Location = new System.Drawing.Point(536, 55);
            this.uxWordsFound.Name = "uxWordsFound";
            this.uxWordsFound.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.uxWordsFound.Size = new System.Drawing.Size(207, 484);
            this.uxWordsFound.TabIndex = 17;
            // 
            // uxWordsFoundLabel
            // 
            this.uxWordsFoundLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxWordsFoundLabel.AutoSize = true;
            this.uxWordsFoundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxWordsFoundLabel.Location = new System.Drawing.Point(536, 28);
            this.uxWordsFoundLabel.Name = "uxWordsFoundLabel";
            this.uxWordsFoundLabel.Size = new System.Drawing.Size(131, 24);
            this.uxWordsFoundLabel.TabIndex = 16;
            this.uxWordsFoundLabel.Text = "Words Found:";
            // 
            // uxOpenDialog
            // 
            this.uxOpenDialog.Title = "Select Dictionary File";
            // 
            // uxMenuBar
            // 
            this.uxMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxNewBoard,
            this.uxFindWords});
            this.uxMenuBar.Location = new System.Drawing.Point(0, 0);
            this.uxMenuBar.Name = "uxMenuBar";
            this.uxMenuBar.Size = new System.Drawing.Size(759, 25);
            this.uxMenuBar.TabIndex = 18;
            this.uxMenuBar.Text = "toolStrip1";
            // 
            // uxNewBoard
            // 
            this.uxNewBoard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.uxNewBoard.Image = ((System.Drawing.Image)(resources.GetObject("uxNewBoard.Image")));
            this.uxNewBoard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxNewBoard.Name = "uxNewBoard";
            this.uxNewBoard.Size = new System.Drawing.Size(69, 22);
            this.uxNewBoard.Text = "New Board";
            this.uxNewBoard.Click += new System.EventHandler(this.uxNewBoard_Click);
            // 
            // uxFindWords
            // 
            this.uxFindWords.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.uxFindWords.Image = ((System.Drawing.Image)(resources.GetObject("uxFindWords.Image")));
            this.uxFindWords.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxFindWords.Name = "uxFindWords";
            this.uxFindWords.Size = new System.Drawing.Size(71, 22);
            this.uxFindWords.Text = "Find Words";
            this.uxFindWords.Click += new System.EventHandler(this.uxFindWords_Click);
            // 
            // uxBoardContainer
            // 
            this.uxBoardContainer.Controls.Add(this.uxBoard);
            this.uxBoardContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBoardContainer.Location = new System.Drawing.Point(12, 28);
            this.uxBoardContainer.Name = "uxBoardContainer";
            this.uxBoardContainer.Size = new System.Drawing.Size(511, 511);
            this.uxBoardContainer.TabIndex = 19;
            // 
            // uxBoard
            // 
            this.uxBoard.AllowUserToAddRows = false;
            this.uxBoard.AllowUserToDeleteRows = false;
            this.uxBoard.AllowUserToResizeColumns = false;
            this.uxBoard.AllowUserToResizeRows = false;
            this.uxBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxBoard.ColumnHeadersVisible = false;
            this.uxBoard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.uxBoard.Enabled = false;
            this.uxBoard.Location = new System.Drawing.Point(3, 3);
            this.uxBoard.Name = "uxBoard";
            this.uxBoard.RowHeadersVisible = false;
            this.uxBoard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.uxBoard.Size = new System.Drawing.Size(504, 505);
            this.uxBoard.TabIndex = 0;
            // 
            // Column0
            // 
            this.Column0.Frozen = true;
            this.Column0.HeaderText = "";
            this.Column0.Name = "Column0";
            this.Column0.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 551);
            this.Controls.Add(this.uxBoardContainer);
            this.Controls.Add(this.uxMenuBar);
            this.Controls.Add(this.uxWordsFound);
            this.Controls.Add(this.uxWordsFoundLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "UserInterface";
            this.Text = "Boggle Deluxe";
            this.Load += new System.EventHandler(this.UserInterface_Load);
            this.uxMenuBar.ResumeLayout(false);
            this.uxMenuBar.PerformLayout();
            this.uxBoardContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uxBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox uxWordsFound;
        private System.Windows.Forms.Label uxWordsFoundLabel;
        private System.Windows.Forms.OpenFileDialog uxOpenDialog;
        private System.Windows.Forms.ToolStrip uxMenuBar;
        private System.Windows.Forms.Panel uxBoardContainer;
        private System.Windows.Forms.DataGridView uxBoard;
        private System.Windows.Forms.ToolStripButton uxFindWords;
        private System.Windows.Forms.ToolStripButton uxNewBoard;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column0;
    }
}

