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
            this.lblUrunAdi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarkod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKutu)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBarkod
            // 
            this.txtBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkod.Location = new System.Drawing.Point(186, 320);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.ReadOnly = true;
            this.txtBarkod.Size = new System.Drawing.Size(283, 32);
            this.txtBarkod.TabIndex = 7;
            this.txtBarkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarkod_KeyDown);
            // 
            // pbBarkod
            // 
            this.pbBarkod.Location = new System.Drawing.Point(173, 37);
            this.pbBarkod.Name = "pbBarkod";
            this.pbBarkod.Size = new System.Drawing.Size(335, 156);
            this.pbBarkod.TabIndex = 6;
            this.pbBarkod.TabStop = false;
            // 
            // nudKutu
            // 
            this.nudKutu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudKutu.Location = new System.Drawing.Point(320, 260);
            this.nudKutu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKutu.Name = "nudKutu";
            this.nudKutu.Size = new System.Drawing.Size(43, 32);
            this.nudKutu.TabIndex = 23;
            this.nudKutu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(257, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 26);
            this.label9.TabIndex = 24;
            this.label9.Text = "Kutu";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAdi.Location = new System.Drawing.Point(1, 211);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(70, 26);
            this.lblUrunAdi.TabIndex = 25;
            this.lblUrunAdi.Text = "label1";
            this.lblUrunAdi.Visible = false;
            // 
            // BarkodOkuma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 385);
            this.Controls.Add(this.lblUrunAdi);
            this.Controls.Add(this.nudKutu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.pbBarkod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BarkodOkuma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label lblUrunAdi;
    }
}