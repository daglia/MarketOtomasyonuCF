namespace Market.WFA
{
    partial class Rapor
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
            this.tabOdemeDetaylari = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbKrediKarti = new System.Windows.Forms.RadioButton();
            this.rbNakit = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOdemeYontemi = new System.Windows.Forms.DataGridView();
            this.tabAylikSatislar = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbYillarAylik = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAylar = new System.Windows.Forms.ComboBox();
            this.dgvAylikSatislar = new System.Windows.Forms.DataGridView();
            this.tabGunlukSatislar = new System.Windows.Forms.TabPage();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.dgvGunlukSatis = new System.Windows.Forms.DataGridView();
            this.tabStok = new System.Windows.Forms.TabPage();
            this.dgvStok = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabYillikSatislar = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbYillar = new System.Windows.Forms.ComboBox();
            this.dgvYillikSatislar = new System.Windows.Forms.DataGridView();
            this.cbKategorilerGunluk = new System.Windows.Forms.CheckBox();
            this.cbKategorilerAylik = new System.Windows.Forms.CheckBox();
            this.cbKategorilerYillik = new System.Windows.Forms.CheckBox();
            this.tabOdemeDetaylari.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdemeYontemi)).BeginInit();
            this.tabAylikSatislar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAylikSatislar)).BeginInit();
            this.tabGunlukSatislar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGunlukSatis)).BeginInit();
            this.tabStok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStok)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabYillikSatislar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYillikSatislar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabOdemeDetaylari
            // 
            this.tabOdemeDetaylari.Controls.Add(this.panel1);
            this.tabOdemeDetaylari.Controls.Add(this.label1);
            this.tabOdemeDetaylari.Controls.Add(this.dgvOdemeYontemi);
            this.tabOdemeDetaylari.Location = new System.Drawing.Point(4, 4);
            this.tabOdemeDetaylari.Name = "tabOdemeDetaylari";
            this.tabOdemeDetaylari.Size = new System.Drawing.Size(1338, 664);
            this.tabOdemeDetaylari.TabIndex = 3;
            this.tabOdemeDetaylari.Text = "Ödeme Detayları";
            this.tabOdemeDetaylari.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbKrediKarti);
            this.panel1.Controls.Add(this.rbNakit);
            this.panel1.Location = new System.Drawing.Point(256, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 35);
            this.panel1.TabIndex = 3;
            // 
            // rbKrediKarti
            // 
            this.rbKrediKarti.AutoSize = true;
            this.rbKrediKarti.Location = new System.Drawing.Point(19, 3);
            this.rbKrediKarti.Name = "rbKrediKarti";
            this.rbKrediKarti.Size = new System.Drawing.Size(132, 30);
            this.rbKrediKarti.TabIndex = 2;
            this.rbKrediKarti.TabStop = true;
            this.rbKrediKarti.Text = "Kredi Kartı";
            this.rbKrediKarti.UseVisualStyleBackColor = true;
            this.rbKrediKarti.CheckedChanged += new System.EventHandler(this.rbKrediKarti_CheckedChanged);
            // 
            // rbNakit
            // 
            this.rbNakit.AutoSize = true;
            this.rbNakit.Location = new System.Drawing.Point(167, 3);
            this.rbNakit.Name = "rbNakit";
            this.rbNakit.Size = new System.Drawing.Size(80, 30);
            this.rbNakit.TabIndex = 2;
            this.rbNakit.TabStop = true;
            this.rbNakit.Text = "Nakit";
            this.rbNakit.UseVisualStyleBackColor = true;
            this.rbNakit.CheckedChanged += new System.EventHandler(this.rbNakit_CheckedChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ödeme Yöntemi";
            // 
            // dgvOdemeYontemi
            // 
            this.dgvOdemeYontemi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOdemeYontemi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOdemeYontemi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdemeYontemi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvOdemeYontemi.Location = new System.Drawing.Point(0, 55);
            this.dgvOdemeYontemi.MultiSelect = false;
            this.dgvOdemeYontemi.Name = "dgvOdemeYontemi";
            this.dgvOdemeYontemi.ReadOnly = true;
            this.dgvOdemeYontemi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOdemeYontemi.Size = new System.Drawing.Size(1338, 609);
            this.dgvOdemeYontemi.TabIndex = 0;
            // 
            // tabAylikSatislar
            // 
            this.tabAylikSatislar.Controls.Add(this.cbKategorilerAylik);
            this.tabAylikSatislar.Controls.Add(this.label4);
            this.tabAylikSatislar.Controls.Add(this.cmbYillarAylik);
            this.tabAylikSatislar.Controls.Add(this.label3);
            this.tabAylikSatislar.Controls.Add(this.cmbAylar);
            this.tabAylikSatislar.Controls.Add(this.dgvAylikSatislar);
            this.tabAylikSatislar.Location = new System.Drawing.Point(4, 4);
            this.tabAylikSatislar.Name = "tabAylikSatislar";
            this.tabAylikSatislar.Size = new System.Drawing.Size(1338, 664);
            this.tabAylikSatislar.TabIndex = 2;
            this.tabAylikSatislar.Text = "Aylık Satışlar";
            this.tabAylikSatislar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Yıl Seçiniz:";
            // 
            // cmbYillarAylik
            // 
            this.cmbYillarAylik.FormattingEnabled = true;
            this.cmbYillarAylik.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018",
            "2019"});
            this.cmbYillarAylik.Location = new System.Drawing.Point(160, 8);
            this.cmbYillarAylik.Name = "cmbYillarAylik";
            this.cmbYillarAylik.Size = new System.Drawing.Size(204, 33);
            this.cmbYillarAylik.TabIndex = 13;
            this.cmbYillarAylik.SelectedIndexChanged += new System.EventHandler(this.cmbYillarAylik_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ay Seçiniz:";
            // 
            // cmbAylar
            // 
            this.cmbAylar.FormattingEnabled = true;
            this.cmbAylar.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbAylar.Location = new System.Drawing.Point(527, 8);
            this.cmbAylar.Name = "cmbAylar";
            this.cmbAylar.Size = new System.Drawing.Size(204, 33);
            this.cmbAylar.TabIndex = 11;
            this.cmbAylar.SelectedIndexChanged += new System.EventHandler(this.cmbAylar_SelectedIndexChanged);
            // 
            // dgvAylikSatislar
            // 
            this.dgvAylikSatislar.AllowUserToAddRows = false;
            this.dgvAylikSatislar.AllowUserToDeleteRows = false;
            this.dgvAylikSatislar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAylikSatislar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAylikSatislar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAylikSatislar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAylikSatislar.Location = new System.Drawing.Point(0, 55);
            this.dgvAylikSatislar.MultiSelect = false;
            this.dgvAylikSatislar.Name = "dgvAylikSatislar";
            this.dgvAylikSatislar.ReadOnly = true;
            this.dgvAylikSatislar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAylikSatislar.Size = new System.Drawing.Size(1338, 609);
            this.dgvAylikSatislar.TabIndex = 10;
            // 
            // tabGunlukSatislar
            // 
            this.tabGunlukSatislar.Controls.Add(this.cbKategorilerGunluk);
            this.tabGunlukSatislar.Controls.Add(this.dtpTarih);
            this.tabGunlukSatislar.Controls.Add(this.dgvGunlukSatis);
            this.tabGunlukSatislar.Location = new System.Drawing.Point(4, 4);
            this.tabGunlukSatislar.Name = "tabGunlukSatislar";
            this.tabGunlukSatislar.Padding = new System.Windows.Forms.Padding(3);
            this.tabGunlukSatislar.Size = new System.Drawing.Size(1338, 664);
            this.tabGunlukSatislar.TabIndex = 1;
            this.tabGunlukSatislar.Text = "Günlük Satışlar";
            this.tabGunlukSatislar.UseVisualStyleBackColor = true;
            // 
            // dtpTarih
            // 
            this.dtpTarih.CustomFormat = "dd.MM.yyyy";
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTarih.Location = new System.Drawing.Point(8, 14);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(290, 32);
            this.dtpTarih.TabIndex = 6;
            this.dtpTarih.ValueChanged += new System.EventHandler(this.dtpTarih_ValueChanged);
            // 
            // dgvGunlukSatis
            // 
            this.dgvGunlukSatis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGunlukSatis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGunlukSatis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGunlukSatis.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvGunlukSatis.Location = new System.Drawing.Point(3, 52);
            this.dgvGunlukSatis.MultiSelect = false;
            this.dgvGunlukSatis.Name = "dgvGunlukSatis";
            this.dgvGunlukSatis.ReadOnly = true;
            this.dgvGunlukSatis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGunlukSatis.Size = new System.Drawing.Size(1332, 609);
            this.dgvGunlukSatis.TabIndex = 4;
            // 
            // tabStok
            // 
            this.tabStok.Controls.Add(this.dgvStok);
            this.tabStok.Location = new System.Drawing.Point(4, 4);
            this.tabStok.Name = "tabStok";
            this.tabStok.Padding = new System.Windows.Forms.Padding(3);
            this.tabStok.Size = new System.Drawing.Size(1338, 664);
            this.tabStok.TabIndex = 0;
            this.tabStok.Text = "Stok";
            this.tabStok.UseVisualStyleBackColor = true;
            // 
            // dgvStok
            // 
            this.dgvStok.AllowUserToAddRows = false;
            this.dgvStok.AllowUserToDeleteRows = false;
            this.dgvStok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStok.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStok.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStok.Location = new System.Drawing.Point(3, 3);
            this.dgvStok.MultiSelect = false;
            this.dgvStok.Name = "dgvStok";
            this.dgvStok.ReadOnly = true;
            this.dgvStok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStok.Size = new System.Drawing.Size(1332, 658);
            this.dgvStok.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabStok);
            this.tabControl1.Controls.Add(this.tabGunlukSatislar);
            this.tabControl1.Controls.Add(this.tabAylikSatislar);
            this.tabControl1.Controls.Add(this.tabYillikSatislar);
            this.tabControl1.Controls.Add(this.tabOdemeDetaylari);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1346, 702);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabYillikSatislar
            // 
            this.tabYillikSatislar.Controls.Add(this.cbKategorilerYillik);
            this.tabYillikSatislar.Controls.Add(this.label2);
            this.tabYillikSatislar.Controls.Add(this.cmbYillar);
            this.tabYillikSatislar.Controls.Add(this.dgvYillikSatislar);
            this.tabYillikSatislar.Location = new System.Drawing.Point(4, 4);
            this.tabYillikSatislar.Name = "tabYillikSatislar";
            this.tabYillikSatislar.Size = new System.Drawing.Size(1338, 664);
            this.tabYillikSatislar.TabIndex = 4;
            this.tabYillikSatislar.Text = "Yıllık Satışlar";
            this.tabYillikSatislar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Yıl Seçiniz:";
            // 
            // cmbYillar
            // 
            this.cmbYillar.FormattingEnabled = true;
            this.cmbYillar.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018",
            "2019"});
            this.cmbYillar.Location = new System.Drawing.Point(135, 13);
            this.cmbYillar.Name = "cmbYillar";
            this.cmbYillar.Size = new System.Drawing.Size(204, 33);
            this.cmbYillar.TabIndex = 8;
            this.cmbYillar.SelectedIndexChanged += new System.EventHandler(this.cmbYillar_SelectedIndexChanged);
            // 
            // dgvYillikSatislar
            // 
            this.dgvYillikSatislar.AllowUserToAddRows = false;
            this.dgvYillikSatislar.AllowUserToDeleteRows = false;
            this.dgvYillikSatislar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvYillikSatislar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvYillikSatislar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYillikSatislar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvYillikSatislar.Location = new System.Drawing.Point(0, 55);
            this.dgvYillikSatislar.MultiSelect = false;
            this.dgvYillikSatislar.Name = "dgvYillikSatislar";
            this.dgvYillikSatislar.ReadOnly = true;
            this.dgvYillikSatislar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvYillikSatislar.Size = new System.Drawing.Size(1338, 609);
            this.dgvYillikSatislar.TabIndex = 7;
            // 
            // cbKategorilerGunluk
            // 
            this.cbKategorilerGunluk.AutoSize = true;
            this.cbKategorilerGunluk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbKategorilerGunluk.Location = new System.Drawing.Point(1134, 19);
            this.cbKategorilerGunluk.Name = "cbKategorilerGunluk";
            this.cbKategorilerGunluk.Size = new System.Drawing.Size(196, 29);
            this.cbKategorilerGunluk.TabIndex = 7;
            this.cbKategorilerGunluk.Text = "Kategorilere göre";
            this.cbKategorilerGunluk.UseVisualStyleBackColor = true;
            this.cbKategorilerGunluk.CheckedChanged += new System.EventHandler(this.cbKategorilerGunluk_CheckedChanged);
            // 
            // cbKategorilerAylik
            // 
            this.cbKategorilerAylik.AutoSize = true;
            this.cbKategorilerAylik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbKategorilerAylik.Location = new System.Drawing.Point(1134, 10);
            this.cbKategorilerAylik.Name = "cbKategorilerAylik";
            this.cbKategorilerAylik.Size = new System.Drawing.Size(196, 29);
            this.cbKategorilerAylik.TabIndex = 15;
            this.cbKategorilerAylik.Text = "Kategorilere göre";
            this.cbKategorilerAylik.UseVisualStyleBackColor = true;
            this.cbKategorilerAylik.CheckedChanged += new System.EventHandler(this.cbKategorilerAylik_CheckedChanged);
            // 
            // cbKategorilerYillik
            // 
            this.cbKategorilerYillik.AutoSize = true;
            this.cbKategorilerYillik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbKategorilerYillik.Location = new System.Drawing.Point(1134, 15);
            this.cbKategorilerYillik.Name = "cbKategorilerYillik";
            this.cbKategorilerYillik.Size = new System.Drawing.Size(196, 29);
            this.cbKategorilerYillik.TabIndex = 10;
            this.cbKategorilerYillik.Text = "Kategorilere göre";
            this.cbKategorilerYillik.UseVisualStyleBackColor = true;
            this.cbKategorilerYillik.CheckedChanged += new System.EventHandler(this.cbKategorilerYillik_CheckedChanged);
            // 
            // Rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 702);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Rapor";
            this.Text = "Rapor";
            this.Activated += new System.EventHandler(this.Rapor_Activated);
            this.Load += new System.EventHandler(this.Rapor_Load);
            this.tabOdemeDetaylari.ResumeLayout(false);
            this.tabOdemeDetaylari.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdemeYontemi)).EndInit();
            this.tabAylikSatislar.ResumeLayout(false);
            this.tabAylikSatislar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAylikSatislar)).EndInit();
            this.tabGunlukSatislar.ResumeLayout(false);
            this.tabGunlukSatislar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGunlukSatis)).EndInit();
            this.tabStok.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStok)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabYillikSatislar.ResumeLayout(false);
            this.tabYillikSatislar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYillikSatislar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn kutuDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabOdemeDetaylari;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbKrediKarti;
        private System.Windows.Forms.RadioButton rbNakit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOdemeYontemi;
        private System.Windows.Forms.TabPage tabAylikSatislar;
        private System.Windows.Forms.TabPage tabGunlukSatislar;
        private System.Windows.Forms.TabPage tabStok;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabYillikSatislar;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.DataGridView dgvGunlukSatis;
        private System.Windows.Forms.DataGridView dgvStok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbYillar;
        private System.Windows.Forms.DataGridView dgvYillikSatislar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAylar;
        private System.Windows.Forms.DataGridView dgvAylikSatislar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbYillarAylik;
        private System.Windows.Forms.CheckBox cbKategorilerGunluk;
        private System.Windows.Forms.CheckBox cbKategorilerAylik;
        private System.Windows.Forms.CheckBox cbKategorilerYillik;
    }
}