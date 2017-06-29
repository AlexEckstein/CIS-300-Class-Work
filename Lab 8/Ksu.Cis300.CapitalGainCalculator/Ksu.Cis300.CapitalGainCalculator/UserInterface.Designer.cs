namespace Ksu.Cis300.CapitalGainCalculator
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
            this.uxGain = new System.Windows.Forms.TextBox();
            this.uxGainLabel = new System.Windows.Forms.Label();
            this.uxOwned = new System.Windows.Forms.TextBox();
            this.uxOwnedLabel = new System.Windows.Forms.Label();
            this.uxSell = new System.Windows.Forms.Button();
            this.uxBuy = new System.Windows.Forms.Button();
            this.uxCost = new System.Windows.Forms.NumericUpDown();
            this.uxCostLabel = new System.Windows.Forms.Label();
            this.uxNumber = new System.Windows.Forms.NumericUpDown();
            this.uxNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // uxGain
            // 
            this.uxGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxGain.Location = new System.Drawing.Point(167, 172);
            this.uxGain.Name = "uxGain";
            this.uxGain.ReadOnly = true;
            this.uxGain.Size = new System.Drawing.Size(213, 29);
            this.uxGain.TabIndex = 59;
            this.uxGain.Text = "0.00";
            this.uxGain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // uxGainLabel
            // 
            this.uxGainLabel.AutoSize = true;
            this.uxGainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxGainLabel.Location = new System.Drawing.Point(18, 175);
            this.uxGainLabel.Name = "uxGainLabel";
            this.uxGainLabel.Size = new System.Drawing.Size(143, 24);
            this.uxGainLabel.TabIndex = 58;
            this.uxGainLabel.Text = "Net capital gain:";
            // 
            // uxOwned
            // 
            this.uxOwned.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxOwned.Location = new System.Drawing.Point(252, 137);
            this.uxOwned.Name = "uxOwned";
            this.uxOwned.ReadOnly = true;
            this.uxOwned.Size = new System.Drawing.Size(128, 29);
            this.uxOwned.TabIndex = 57;
            this.uxOwned.Text = "0";
            this.uxOwned.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // uxOwnedLabel
            // 
            this.uxOwnedLabel.AutoSize = true;
            this.uxOwnedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxOwnedLabel.Location = new System.Drawing.Point(18, 140);
            this.uxOwnedLabel.Name = "uxOwnedLabel";
            this.uxOwnedLabel.Size = new System.Drawing.Size(228, 24);
            this.uxOwnedLabel.TabIndex = 56;
            this.uxOwnedLabel.Text = "Number of shares owned:";
            // 
            // uxSell
            // 
            this.uxSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSell.Location = new System.Drawing.Point(204, 89);
            this.uxSell.Name = "uxSell";
            this.uxSell.Size = new System.Drawing.Size(176, 42);
            this.uxSell.TabIndex = 55;
            this.uxSell.Text = "Sell";
            this.uxSell.UseVisualStyleBackColor = true;
            this.uxSell.Click += new System.EventHandler(this.uxSell_Click);
            // 
            // uxBuy
            // 
            this.uxBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBuy.Location = new System.Drawing.Point(22, 89);
            this.uxBuy.Name = "uxBuy";
            this.uxBuy.Size = new System.Drawing.Size(176, 42);
            this.uxBuy.TabIndex = 54;
            this.uxBuy.Text = "Buy";
            this.uxBuy.UseVisualStyleBackColor = true;
            this.uxBuy.Click += new System.EventHandler(this.uxBuy_Click);
            // 
            // uxCost
            // 
            this.uxCost.DecimalPlaces = 2;
            this.uxCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCost.Location = new System.Drawing.Point(195, 54);
            this.uxCost.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.uxCost.Name = "uxCost";
            this.uxCost.Size = new System.Drawing.Size(185, 29);
            this.uxCost.TabIndex = 53;
            this.uxCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // uxCostLabel
            // 
            this.uxCostLabel.AutoSize = true;
            this.uxCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCostLabel.Location = new System.Drawing.Point(18, 58);
            this.uxCostLabel.Name = "uxCostLabel";
            this.uxCostLabel.Size = new System.Drawing.Size(171, 24);
            this.uxCostLabel.TabIndex = 52;
            this.uxCostLabel.Text = "Cost of each share:";
            // 
            // uxNumber
            // 
            this.uxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNumber.Location = new System.Drawing.Point(304, 19);
            this.uxNumber.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.uxNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uxNumber.Name = "uxNumber";
            this.uxNumber.Size = new System.Drawing.Size(76, 29);
            this.uxNumber.TabIndex = 51;
            this.uxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.uxNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // uxNumberLabel
            // 
            this.uxNumberLabel.AutoSize = true;
            this.uxNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNumberLabel.Location = new System.Drawing.Point(18, 21);
            this.uxNumberLabel.Name = "uxNumberLabel";
            this.uxNumberLabel.Size = new System.Drawing.Size(280, 24);
            this.uxNumberLabel.TabIndex = 50;
            this.uxNumberLabel.Text = "Number of shares in transaction:";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 220);
            this.Controls.Add(this.uxGain);
            this.Controls.Add(this.uxGainLabel);
            this.Controls.Add(this.uxOwned);
            this.Controls.Add(this.uxOwnedLabel);
            this.Controls.Add(this.uxSell);
            this.Controls.Add(this.uxBuy);
            this.Controls.Add(this.uxCost);
            this.Controls.Add(this.uxCostLabel);
            this.Controls.Add(this.uxNumber);
            this.Controls.Add(this.uxNumberLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "UserInterface";
            this.Text = "Capital Gain Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.uxCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxGain;
        private System.Windows.Forms.Label uxGainLabel;
        private System.Windows.Forms.TextBox uxOwned;
        private System.Windows.Forms.Label uxOwnedLabel;
        private System.Windows.Forms.Button uxSell;
        private System.Windows.Forms.Button uxBuy;
        private System.Windows.Forms.NumericUpDown uxCost;
        private System.Windows.Forms.Label uxCostLabel;
        private System.Windows.Forms.NumericUpDown uxNumber;
        private System.Windows.Forms.Label uxNumberLabel;
    }
}

