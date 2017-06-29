namespace Ksu.Cis300.PrimeNumbers
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
            this.uxPrimes = new System.Windows.Forms.ListBox();
            this.uxFindPrimes = new System.Windows.Forms.Button();
            this.uxPrimesLabel = new System.Windows.Forms.Label();
            this.uxInput = new System.Windows.Forms.NumericUpDown();
            this.uxInputLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxInput)).BeginInit();
            this.SuspendLayout();
            // 
            // uxPrimes
            // 
            this.uxPrimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPrimes.FormattingEnabled = true;
            this.uxPrimes.ItemHeight = 24;
            this.uxPrimes.Location = new System.Drawing.Point(23, 124);
            this.uxPrimes.Name = "uxPrimes";
            this.uxPrimes.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.uxPrimes.Size = new System.Drawing.Size(254, 244);
            this.uxPrimes.TabIndex = 19;
            // 
            // uxFindPrimes
            // 
            this.uxFindPrimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFindPrimes.Location = new System.Drawing.Point(23, 55);
            this.uxFindPrimes.Name = "uxFindPrimes";
            this.uxFindPrimes.Size = new System.Drawing.Size(254, 31);
            this.uxFindPrimes.TabIndex = 18;
            this.uxFindPrimes.Text = "Find Primes";
            this.uxFindPrimes.UseVisualStyleBackColor = true;
            this.uxFindPrimes.Click += new System.EventHandler(this.uxFindPrimes_Click);
            // 
            // uxPrimesLabel
            // 
            this.uxPrimesLabel.AutoSize = true;
            this.uxPrimesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPrimesLabel.Location = new System.Drawing.Point(19, 89);
            this.uxPrimesLabel.Name = "uxPrimesLabel";
            this.uxPrimesLabel.Size = new System.Drawing.Size(168, 24);
            this.uxPrimesLabel.TabIndex = 17;
            this.uxPrimesLabel.Text = "Primes less than n:";
            // 
            // uxInput
            // 
            this.uxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxInput.Location = new System.Drawing.Point(101, 20);
            this.uxInput.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.uxInput.Name = "uxInput";
            this.uxInput.Size = new System.Drawing.Size(176, 29);
            this.uxInput.TabIndex = 16;
            this.uxInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // uxInputLabel
            // 
            this.uxInputLabel.AutoSize = true;
            this.uxInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxInputLabel.Location = new System.Drawing.Point(19, 22);
            this.uxInputLabel.Name = "uxInputLabel";
            this.uxInputLabel.Size = new System.Drawing.Size(76, 24);
            this.uxInputLabel.TabIndex = 15;
            this.uxInputLabel.Text = "Enter n:";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 388);
            this.Controls.Add(this.uxPrimes);
            this.Controls.Add(this.uxFindPrimes);
            this.Controls.Add(this.uxPrimesLabel);
            this.Controls.Add(this.uxInput);
            this.Controls.Add(this.uxInputLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "UserInterface";
            this.Text = "Prime Numbers";
            ((System.ComponentModel.ISupportInitialize)(this.uxInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox uxPrimes;
        private System.Windows.Forms.Button uxFindPrimes;
        private System.Windows.Forms.Label uxPrimesLabel;
        private System.Windows.Forms.NumericUpDown uxInput;
        private System.Windows.Forms.Label uxInputLabel;
    }
}

