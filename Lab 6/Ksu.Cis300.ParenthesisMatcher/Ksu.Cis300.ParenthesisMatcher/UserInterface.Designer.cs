namespace Ksu.Cis300.ParenthesisMatcher
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
            this.uxInputLabel = new System.Windows.Forms.Label();
            this.uxInput = new System.Windows.Forms.TextBox();
            this.uxCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxInputLabel
            // 
            this.uxInputLabel.AutoSize = true;
            this.uxInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxInputLabel.Location = new System.Drawing.Point(12, 15);
            this.uxInputLabel.Name = "uxInputLabel";
            this.uxInputLabel.Size = new System.Drawing.Size(113, 24);
            this.uxInputLabel.TabIndex = 0;
            this.uxInputLabel.Text = "Enter String:";
            // 
            // uxInput
            // 
            this.uxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxInput.Location = new System.Drawing.Point(131, 12);
            this.uxInput.Name = "uxInput";
            this.uxInput.Size = new System.Drawing.Size(255, 29);
            this.uxInput.TabIndex = 1;
            // 
            // uxCheck
            // 
            this.uxCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCheck.Location = new System.Drawing.Point(131, 47);
            this.uxCheck.Name = "uxCheck";
            this.uxCheck.Size = new System.Drawing.Size(138, 32);
            this.uxCheck.TabIndex = 2;
            this.uxCheck.Text = "Check";
            this.uxCheck.UseVisualStyleBackColor = true;
            this.uxCheck.Click += new System.EventHandler(this.uxCheck_Click);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 91);
            this.Controls.Add(this.uxCheck);
            this.Controls.Add(this.uxInput);
            this.Controls.Add(this.uxInputLabel);
            this.Name = "UserInterface";
            this.Text = "Parenthesis Matcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxInputLabel;
        private System.Windows.Forms.TextBox uxInput;
        private System.Windows.Forms.Button uxCheck;
    }
}

