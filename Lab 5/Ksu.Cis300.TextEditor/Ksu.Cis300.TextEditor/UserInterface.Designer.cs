namespace Ksu.Cis300.TextEditor
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
            this.uxMenuBar = new System.Windows.Forms.MenuStrip();
            this.uxFile = new System.Windows.Forms.ToolStripMenuItem();
            this.uxOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.uxSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.uxEncrypt = new System.Windows.Forms.ToolStripMenuItem();
            this.uxEncryptWithString = new System.Windows.Forms.ToolStripMenuItem();
            this.uxEncryptWithStringBuilder = new System.Windows.Forms.ToolStripMenuItem();
            this.uxDisplay = new System.Windows.Forms.TextBox();
            this.uxOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxSaveAsDialog = new System.Windows.Forms.SaveFileDialog();
            this.uxEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.uxUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.uxRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxMenuBar
            // 
            this.uxMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxFile,
            this.uxEncrypt,
            this.uxEdit});
            this.uxMenuBar.Location = new System.Drawing.Point(0, 0);
            this.uxMenuBar.Name = "uxMenuBar";
            this.uxMenuBar.Size = new System.Drawing.Size(612, 24);
            this.uxMenuBar.TabIndex = 0;
            this.uxMenuBar.Text = "menuStrip1";
            // 
            // uxFile
            // 
            this.uxFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxOpen,
            this.uxSaveAs});
            this.uxFile.Name = "uxFile";
            this.uxFile.Size = new System.Drawing.Size(37, 20);
            this.uxFile.Text = "File";
            // 
            // uxOpen
            // 
            this.uxOpen.Name = "uxOpen";
            this.uxOpen.Size = new System.Drawing.Size(123, 22);
            this.uxOpen.Text = "Open...";
            this.uxOpen.Click += new System.EventHandler(this.uxOpen_Click);
            // 
            // uxSaveAs
            // 
            this.uxSaveAs.Name = "uxSaveAs";
            this.uxSaveAs.Size = new System.Drawing.Size(123, 22);
            this.uxSaveAs.Text = "Save As...";
            this.uxSaveAs.Click += new System.EventHandler(this.uxSaveAs_Click);
            // 
            // uxEncrypt
            // 
            this.uxEncrypt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxEncryptWithString,
            this.uxEncryptWithStringBuilder});
            this.uxEncrypt.Name = "uxEncrypt";
            this.uxEncrypt.Size = new System.Drawing.Size(59, 20);
            this.uxEncrypt.Text = "Encrypt";
            // 
            // uxEncryptWithString
            // 
            this.uxEncryptWithString.Name = "uxEncryptWithString";
            this.uxEncryptWithString.Size = new System.Drawing.Size(170, 22);
            this.uxEncryptWithString.Text = "With String";
            this.uxEncryptWithString.Click += new System.EventHandler(this.uxEncryptWithString_Click);
            // 
            // uxEncryptWithStringBuilder
            // 
            this.uxEncryptWithStringBuilder.Name = "uxEncryptWithStringBuilder";
            this.uxEncryptWithStringBuilder.Size = new System.Drawing.Size(170, 22);
            this.uxEncryptWithStringBuilder.Text = "With StringBuilder";
            this.uxEncryptWithStringBuilder.Click += new System.EventHandler(this.uxEncryptWithStringBuilder_Click);
            // 
            // uxDisplay
            // 
            this.uxDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxDisplay.Location = new System.Drawing.Point(12, 27);
            this.uxDisplay.MaxLength = 0;
            this.uxDisplay.Multiline = true;
            this.uxDisplay.Name = "uxDisplay";
            this.uxDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxDisplay.Size = new System.Drawing.Size(588, 341);
            this.uxDisplay.TabIndex = 1;
            this.uxDisplay.TextChanged += new System.EventHandler(this.uxDisplay_TextChanged);
            // 
            // uxEdit
            // 
            this.uxEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxUndo,
            this.uxRedo});
            this.uxEdit.Name = "uxEdit";
            this.uxEdit.Size = new System.Drawing.Size(39, 20);
            this.uxEdit.Text = "Edit";
            // 
            // uxUndo
            // 
            this.uxUndo.Enabled = false;
            this.uxUndo.Name = "uxUndo";
            this.uxUndo.Size = new System.Drawing.Size(152, 22);
            this.uxUndo.Text = "Undo";
            this.uxUndo.Click += new System.EventHandler(this.uxUndo_Click);
            // 
            // uxRedo
            // 
            this.uxRedo.Enabled = false;
            this.uxRedo.Name = "uxRedo";
            this.uxRedo.Size = new System.Drawing.Size(152, 22);
            this.uxRedo.Text = "Redo";
            this.uxRedo.Click += new System.EventHandler(this.uxRedo_Click);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 380);
            this.Controls.Add(this.uxDisplay);
            this.Controls.Add(this.uxMenuBar);
            this.MainMenuStrip = this.uxMenuBar;
            this.Name = "UserInterface";
            this.Text = "Text Editor";
            this.uxMenuBar.ResumeLayout(false);
            this.uxMenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip uxMenuBar;
        private System.Windows.Forms.ToolStripMenuItem uxFile;
        private System.Windows.Forms.ToolStripMenuItem uxOpen;
        private System.Windows.Forms.ToolStripMenuItem uxSaveAs;
        private System.Windows.Forms.TextBox uxDisplay;
        private System.Windows.Forms.OpenFileDialog uxOpenDialog;
        private System.Windows.Forms.SaveFileDialog uxSaveAsDialog;
        private System.Windows.Forms.ToolStripMenuItem uxEncrypt;
        private System.Windows.Forms.ToolStripMenuItem uxEncryptWithString;
        private System.Windows.Forms.ToolStripMenuItem uxEncryptWithStringBuilder;
        private System.Windows.Forms.ToolStripMenuItem uxEdit;
        private System.Windows.Forms.ToolStripMenuItem uxUndo;
        private System.Windows.Forms.ToolStripMenuItem uxRedo;
    }
}

