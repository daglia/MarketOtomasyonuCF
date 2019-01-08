namespace Market.WFA
{
    partial class BarkodOkuma
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
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.pbBarkod = new System.Windows.Forms.PictureBox();
            this.nudKutu = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarkod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKutu)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(172, 227);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.ReadOnly = true;
            this.txtBarkod.Size = new System.Drawing.Size(214, 20);
            this.txtBarkod.TabIndex = 7;
            this.txtBarkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarkod_KeyDown);
            // 
            // pbBarkod
            // 
            this.pbBarkod.Location = new System.Drawing.Point(137, 23);
            this.pbBarkod.Name = "pbBarkod";
            this.pbBarkod.Size = new System.Drawing.Size(283, 152);
            this.pbBarkod.TabIndex = 6;
            this.pbBarkod.TabStop = false;
            // 
            // nudKutu
            // 
            this.nudKutu.Location = new System.Drawing.Point(272, 201);
            this.nudKutu.Name = "nudKutu";
            this.nudKutu.Size = new System.Drawing.Size(43, 20);
            this.nudKutu.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(237, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Kutu";
            // 
            // BarkodOkuma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 321);
            this.Controls.Add(this.nudKutu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.pbBarkod);
            this.Name = "BarkodOkuma";
            this.Text = "BarkodOkuma";
            this.Load += new System.EventHandler(this.BarkodOkuma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBarkod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKutu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.PictureBox pbBarkod;
        private System.Windows.Forms.NumericUpDown nudKutu;
        private System.Windows.Forms.Label label9;
    }
}