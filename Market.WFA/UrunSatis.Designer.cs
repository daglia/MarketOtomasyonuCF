namespace Market.WFA
{
    partial class UrunSatis
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
            this.components = new System.ComponentModel.Container();
            this.lstSatis = new System.Windows.Forms.ListBox();
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.cbPoset = new System.Windows.Forms.CheckBox();
            this.nudPoset = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbKrediKarti = new System.Windows.Forms.RadioButton();
            this.rbNakit = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.btnIslemiBitir = new System.Windows.Forms.Button();
            this.pnlNakit = new System.Windows.Forms.Panel();
            this.lblParaUstu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudAlinanPara = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoset)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlNakit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlinanPara)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSatis
            // 
            this.lstSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSatis.FormattingEnabled = true;
            this.lstSatis.ItemHeight = 25;
            this.lstSatis.Location = new System.Drawing.Point(736, 37);
            this.lstSatis.Name = "lstSatis";
            this.lstSatis.Size = new System.Drawing.Size(593, 554);
            this.lstSatis.TabIndex = 0;
            this.lstSatis.ContextMenuStripChanged += new System.EventHandler(this.lstSatis_ContextMenuStripChanged);
            // 
            // lstUrunler
            // 
            this.lstUrunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.ItemHeight = 25;
            this.lstUrunler.Location = new System.Drawing.Point(27, 37);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(571, 229);
            this.lstUrunler.TabIndex = 1;
            // 
            // txtBarkod
            // 
            this.txtBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkod.Location = new System.Drawing.Point(108, 311);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(279, 31);
            this.txtBarkod.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Barkod";
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(491, 311);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(107, 31);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // nudAdet
            // 
            this.nudAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudAdet.Location = new System.Drawing.Point(393, 311);
            this.nudAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(92, 31);
            this.nudAdet.TabIndex = 5;
            this.nudAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbPoset
            // 
            this.cbPoset.AutoSize = true;
            this.cbPoset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbPoset.Location = new System.Drawing.Point(503, 358);
            this.cbPoset.Name = "cbPoset";
            this.cbPoset.Size = new System.Drawing.Size(86, 29);
            this.cbPoset.TabIndex = 6;
            this.cbPoset.Text = "Poşet";
            this.cbPoset.UseVisualStyleBackColor = true;
            this.cbPoset.CheckedChanged += new System.EventHandler(this.cbPoset_CheckedChanged);
            // 
            // nudPoset
            // 
            this.nudPoset.Enabled = false;
            this.nudPoset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudPoset.Location = new System.Drawing.Point(393, 358);
            this.nudPoset.Name = "nudPoset";
            this.nudPoset.Size = new System.Drawing.Size(92, 31);
            this.nudPoset.TabIndex = 7;
            this.nudPoset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbKrediKarti);
            this.groupBox1.Controls.Add(this.rbNakit);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(17, 422);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 74);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ödeme Tipi";
            // 
            // rbKrediKarti
            // 
            this.rbKrediKarti.AutoSize = true;
            this.rbKrediKarti.Location = new System.Drawing.Point(376, 30);
            this.rbKrediKarti.Name = "rbKrediKarti";
            this.rbKrediKarti.Size = new System.Drawing.Size(130, 29);
            this.rbKrediKarti.TabIndex = 1;
            this.rbKrediKarti.TabStop = true;
            this.rbKrediKarti.Text = "Kredi Kartı";
            this.rbKrediKarti.UseVisualStyleBackColor = true;
            this.rbKrediKarti.CheckedChanged += new System.EventHandler(this.rbKrediKarti_CheckedChanged);
            // 
            // rbNakit
            // 
            this.rbNakit.AutoSize = true;
            this.rbNakit.Location = new System.Drawing.Point(91, 30);
            this.rbNakit.Name = "rbNakit";
            this.rbNakit.Size = new System.Drawing.Size(79, 29);
            this.rbNakit.TabIndex = 0;
            this.rbNakit.TabStop = true;
            this.rbNakit.Text = "Nakit";
            this.rbNakit.UseVisualStyleBackColor = true;
            this.rbNakit.CheckedChanged += new System.EventHandler(this.rbNakit_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(1009, 633);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "TOPLAM:";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblToplam.Location = new System.Drawing.Point(1268, 633);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(82, 37);
            this.lblToplam.TabIndex = 11;
            this.lblToplam.Text = "0 TL";
            // 
            // btnIslemiBitir
            // 
            this.btnIslemiBitir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIslemiBitir.Location = new System.Drawing.Point(27, 597);
            this.btnIslemiBitir.Name = "btnIslemiBitir";
            this.btnIslemiBitir.Size = new System.Drawing.Size(571, 114);
            this.btnIslemiBitir.TabIndex = 16;
            this.btnIslemiBitir.Text = "İşlemi Bitir";
            this.btnIslemiBitir.UseVisualStyleBackColor = true;
            // 
            // pnlNakit
            // 
            this.pnlNakit.Controls.Add(this.lblParaUstu);
            this.pnlNakit.Controls.Add(this.label4);
            this.pnlNakit.Controls.Add(this.label3);
            this.pnlNakit.Controls.Add(this.nudAlinanPara);
            this.pnlNakit.Location = new System.Drawing.Point(17, 502);
            this.pnlNakit.Name = "pnlNakit";
            this.pnlNakit.Size = new System.Drawing.Size(581, 78);
            this.pnlNakit.TabIndex = 17;
            this.pnlNakit.Visible = false;
            // 
            // lblParaUstu
            // 
            this.lblParaUstu.AutoSize = true;
            this.lblParaUstu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParaUstu.Location = new System.Drawing.Point(489, 23);
            this.lblParaUstu.Name = "lblParaUstu";
            this.lblParaUstu.Size = new System.Drawing.Size(85, 25);
            this.lblParaUstu.TabIndex = 19;
            this.lblParaUstu.Text = "0,00 TL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(376, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Para Üstü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(5, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Alınan";
            // 
            // nudAlinanPara
            // 
            this.nudAlinanPara.DecimalPlaces = 2;
            this.nudAlinanPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudAlinanPara.Location = new System.Drawing.Point(91, 21);
            this.nudAlinanPara.Name = "nudAlinanPara";
            this.nudAlinanPara.Size = new System.Drawing.Size(279, 31);
            this.nudAlinanPara.TabIndex = 16;
            this.nudAlinanPara.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(87, 26);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // UrunSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.pnlNakit);
            this.Controls.Add(this.btnIslemiBitir);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nudPoset);
            this.Controls.Add(this.cbPoset);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.lstUrunler);
            this.Controls.Add(this.lstSatis);
            this.MinimizeBox = false;
            this.Name = "UrunSatis";
            this.Text = "Ürün Satış";
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoset)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlNakit.ResumeLayout(false);
            this.pnlNakit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlinanPara)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSatis;
        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.CheckBox cbPoset;
        private System.Windows.Forms.NumericUpDown nudPoset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbKrediKarti;
        private System.Windows.Forms.RadioButton rbNakit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Button btnIslemiBitir;
        private System.Windows.Forms.Panel pnlNakit;
        private System.Windows.Forms.Label lblParaUstu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudAlinanPara;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}