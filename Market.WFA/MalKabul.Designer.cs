namespace Market.WFA
{
    partial class MalKabul
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
            this.txtAra = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnBarkodOku = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nudKar = new System.Windows.Forms.NumericUpDown();
            this.nudKDV = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblUrunBilgileri = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nudKutu = new System.Windows.Forms.NumericUpDown();
            this.btnStogaEkle = new System.Windows.Forms.Button();
            this.tvUrunler = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKutu)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(13, 26);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(248, 20);
            this.txtAra.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Arama";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Barkod";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(305, 190);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(57, 34);
            this.btnEkle.TabIndex = 19;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnBarkodOku
            // 
            this.btnBarkodOku.Location = new System.Drawing.Point(319, 25);
            this.btnBarkodOku.Name = "btnBarkodOku";
            this.btnBarkodOku.Size = new System.Drawing.Size(170, 23);
            this.btnBarkodOku.TabIndex = 24;
            this.btnBarkodOku.Text = "Barkod Oku";
            this.btnBarkodOku.UseVisualStyleBackColor = true;
            this.btnBarkodOku.Click += new System.EventHandler(this.btnBarkodOku_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.güncelleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 48);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // nudKar
            // 
            this.nudKar.Location = new System.Drawing.Point(368, 159);
            this.nudKar.Name = "nudKar";
            this.nudKar.Size = new System.Drawing.Size(121, 20);
            this.nudKar.TabIndex = 31;
            // 
            // nudKDV
            // 
            this.nudKDV.Location = new System.Drawing.Point(368, 131);
            this.nudKDV.Name = "nudKDV";
            this.nudKDV.Size = new System.Drawing.Size(121, 20);
            this.nudKDV.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Kâr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "KDV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Kategori Adı";
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Location = new System.Drawing.Point(368, 104);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(121, 20);
            this.txtKategoriAdi.TabIndex = 26;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(368, 190);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(57, 34);
            this.btnGuncelle.TabIndex = 32;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(432, 190);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(57, 34);
            this.btnSil.TabIndex = 33;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // lblUrunBilgileri
            // 
            this.lblUrunBilgileri.AutoSize = true;
            this.lblUrunBilgileri.Location = new System.Drawing.Point(272, 243);
            this.lblUrunBilgileri.Name = "lblUrunBilgileri";
            this.lblUrunBilgileri.Size = new System.Drawing.Size(65, 13);
            this.lblUrunBilgileri.TabIndex = 34;
            this.lblUrunBilgileri.Text = "Ürün Bilgileri";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(284, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Kutu";
            // 
            // nudKutu
            // 
            this.nudKutu.Location = new System.Drawing.Point(319, 54);
            this.nudKutu.Name = "nudKutu";
            this.nudKutu.Size = new System.Drawing.Size(43, 20);
            this.nudKutu.TabIndex = 21;
            // 
            // btnStogaEkle
            // 
            this.btnStogaEkle.Location = new System.Drawing.Point(368, 52);
            this.btnStogaEkle.Name = "btnStogaEkle";
            this.btnStogaEkle.Size = new System.Drawing.Size(121, 23);
            this.btnStogaEkle.TabIndex = 23;
            this.btnStogaEkle.Text = "Stoğa Ekle";
            this.btnStogaEkle.UseVisualStyleBackColor = true;
            // 
            // tvUrunler
            // 
            this.tvUrunler.Location = new System.Drawing.Point(12, 54);
            this.tvUrunler.Name = "tvUrunler";
            this.tvUrunler.Size = new System.Drawing.Size(249, 345);
            this.tvUrunler.TabIndex = 35;
            // 
            // MalKabul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 411);
            this.Controls.Add(this.tvUrunler);
            this.Controls.Add(this.lblUrunBilgileri);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.nudKar);
            this.Controls.Add(this.nudKDV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKategoriAdi);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnBarkodOku);
            this.Controls.Add(this.btnStogaEkle);
            this.Controls.Add(this.nudKutu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtAra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MalKabul";
            this.Text = "Mal Kabul";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudKar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKutu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBarkodOku;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown nudKar;
        private System.Windows.Forms.NumericUpDown nudKDV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKategoriAdi;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblUrunBilgileri;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudKutu;
        private System.Windows.Forms.Button btnStogaEkle;
        private System.Windows.Forms.TreeView tvUrunler;
    }
}

