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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabStok = new System.Windows.Forms.TabPage();
            this.dgvStok = new System.Windows.Forms.DataGridView();
            this.tabGunlukSatislar = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabAylikSatislar = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabYillikSatislar = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.marketDbDataSet = new Market.WFA.MarketDbDataSet();
            this.urunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunlerTableAdapter = new Market.WFA.MarketDbDataSetTableAdapters.UrunlerTableAdapter();
            this.urunIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunBarkodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kutuBasinaAdetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ındirimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kutuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabStok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStok)).BeginInit();
            this.tabGunlukSatislar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabAylikSatislar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabYillikSatislar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabStok);
            this.tabControl1.Controls.Add(this.tabGunlukSatislar);
            this.tabControl1.Controls.Add(this.tabAylikSatislar);
            this.tabControl1.Controls.Add(this.tabYillikSatislar);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabStok
            // 
            this.tabStok.Controls.Add(this.dgvStok);
            this.tabStok.Location = new System.Drawing.Point(4, 4);
            this.tabStok.Name = "tabStok";
            this.tabStok.Padding = new System.Windows.Forms.Padding(3);
            this.tabStok.Size = new System.Drawing.Size(792, 412);
            this.tabStok.TabIndex = 0;
            this.tabStok.Text = "Stok";
            this.tabStok.UseVisualStyleBackColor = true;
            this.tabStok.Click += new System.EventHandler(this.tabStok_Click);
            // 
            // dgvStok
            // 
            this.dgvStok.AutoGenerateColumns = false;
            this.dgvStok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStok.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvStok.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvStok.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunIdDataGridViewTextBoxColumn,
            this.urunBarkodDataGridViewTextBoxColumn,
            this.urunAdiDataGridViewTextBoxColumn,
            this.kutuBasinaAdetDataGridViewTextBoxColumn,
            this.birimFiyatDataGridViewTextBoxColumn,
            this.ındirimDataGridViewTextBoxColumn,
            this.kutuDataGridViewTextBoxColumn,
            this.stokDataGridViewTextBoxColumn});
            this.dgvStok.DataSource = this.urunlerBindingSource;
            this.dgvStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStok.Location = new System.Drawing.Point(3, 3);
            this.dgvStok.MultiSelect = false;
            this.dgvStok.Name = "dgvStok";
            this.dgvStok.ReadOnly = true;
            this.dgvStok.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvStok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStok.Size = new System.Drawing.Size(786, 406);
            this.dgvStok.TabIndex = 1;
            // 
            // tabGunlukSatislar
            // 
            this.tabGunlukSatislar.Controls.Add(this.dataGridView2);
            this.tabGunlukSatislar.Location = new System.Drawing.Point(4, 4);
            this.tabGunlukSatislar.Name = "tabGunlukSatislar";
            this.tabGunlukSatislar.Padding = new System.Windows.Forms.Padding(3);
            this.tabGunlukSatislar.Size = new System.Drawing.Size(792, 412);
            this.tabGunlukSatislar.TabIndex = 1;
            this.tabGunlukSatislar.Text = "Günlük Satışlar";
            this.tabGunlukSatislar.UseVisualStyleBackColor = true;
            this.tabGunlukSatislar.Click += new System.EventHandler(this.tabGunlukSatislar_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(786, 406);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // tabAylikSatislar
            // 
            this.tabAylikSatislar.Controls.Add(this.dataGridView3);
            this.tabAylikSatislar.Location = new System.Drawing.Point(4, 4);
            this.tabAylikSatislar.Name = "tabAylikSatislar";
            this.tabAylikSatislar.Size = new System.Drawing.Size(792, 412);
            this.tabAylikSatislar.TabIndex = 2;
            this.tabAylikSatislar.Text = "Aylık Satışlar";
            this.tabAylikSatislar.UseVisualStyleBackColor = true;
            this.tabAylikSatislar.Click += new System.EventHandler(this.tabAylikSatislar_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(792, 412);
            this.dataGridView3.TabIndex = 1;
            // 
            // tabYillikSatislar
            // 
            this.tabYillikSatislar.Controls.Add(this.dataGridView4);
            this.tabYillikSatislar.Location = new System.Drawing.Point(4, 4);
            this.tabYillikSatislar.Name = "tabYillikSatislar";
            this.tabYillikSatislar.Size = new System.Drawing.Size(792, 412);
            this.tabYillikSatislar.TabIndex = 3;
            this.tabYillikSatislar.Text = "Yıllık Satışlar";
            this.tabYillikSatislar.UseVisualStyleBackColor = true;
            this.tabYillikSatislar.Click += new System.EventHandler(this.tabYillikSatislar_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(0, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(792, 412);
            this.dataGridView4.TabIndex = 0;
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // marketDbDataSet
            // 
            this.marketDbDataSet.DataSetName = "MarketDbDataSet";
            this.marketDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunlerBindingSource
            // 
            this.urunlerBindingSource.DataMember = "Urunler";
            this.urunlerBindingSource.DataSource = this.marketDbDataSet;
            // 
            // urunlerTableAdapter
            // 
            this.urunlerTableAdapter.ClearBeforeFill = true;
            // 
            // urunIdDataGridViewTextBoxColumn
            // 
            this.urunIdDataGridViewTextBoxColumn.DataPropertyName = "UrunId";
            this.urunIdDataGridViewTextBoxColumn.HeaderText = "UrunId";
            this.urunIdDataGridViewTextBoxColumn.Name = "urunIdDataGridViewTextBoxColumn";
            this.urunIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunBarkodDataGridViewTextBoxColumn
            // 
            this.urunBarkodDataGridViewTextBoxColumn.DataPropertyName = "UrunBarkod";
            this.urunBarkodDataGridViewTextBoxColumn.HeaderText = "UrunBarkod";
            this.urunBarkodDataGridViewTextBoxColumn.Name = "urunBarkodDataGridViewTextBoxColumn";
            this.urunBarkodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunAdiDataGridViewTextBoxColumn
            // 
            this.urunAdiDataGridViewTextBoxColumn.DataPropertyName = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.HeaderText = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.Name = "urunAdiDataGridViewTextBoxColumn";
            this.urunAdiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kutuBasinaAdetDataGridViewTextBoxColumn
            // 
            this.kutuBasinaAdetDataGridViewTextBoxColumn.DataPropertyName = "KutuBasinaAdet";
            this.kutuBasinaAdetDataGridViewTextBoxColumn.HeaderText = "KutuBasinaAdet";
            this.kutuBasinaAdetDataGridViewTextBoxColumn.Name = "kutuBasinaAdetDataGridViewTextBoxColumn";
            this.kutuBasinaAdetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birimFiyatDataGridViewTextBoxColumn
            // 
            this.birimFiyatDataGridViewTextBoxColumn.DataPropertyName = "BirimFiyat";
            this.birimFiyatDataGridViewTextBoxColumn.HeaderText = "BirimFiyat";
            this.birimFiyatDataGridViewTextBoxColumn.Name = "birimFiyatDataGridViewTextBoxColumn";
            this.birimFiyatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ındirimDataGridViewTextBoxColumn
            // 
            this.ındirimDataGridViewTextBoxColumn.DataPropertyName = "Indirim";
            this.ındirimDataGridViewTextBoxColumn.HeaderText = "Indirim";
            this.ındirimDataGridViewTextBoxColumn.Name = "ındirimDataGridViewTextBoxColumn";
            this.ındirimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kutuDataGridViewTextBoxColumn
            // 
            this.kutuDataGridViewTextBoxColumn.DataPropertyName = "Kutu";
            this.kutuDataGridViewTextBoxColumn.HeaderText = "Kutu";
            this.kutuDataGridViewTextBoxColumn.Name = "kutuDataGridViewTextBoxColumn";
            this.kutuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stokDataGridViewTextBoxColumn
            // 
            this.stokDataGridViewTextBoxColumn.DataPropertyName = "Stok";
            this.stokDataGridViewTextBoxColumn.HeaderText = "Stok";
            this.stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            this.stokDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Rapor";
            this.Text = "Rapor";
            this.Load += new System.EventHandler(this.Rapor_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabStok.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStok)).EndInit();
            this.tabGunlukSatislar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabAylikSatislar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabYillikSatislar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabStok;
        private System.Windows.Forms.TabPage tabGunlukSatislar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabAylikSatislar;
        private System.Windows.Forms.TabPage tabYillikSatislar;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dgvStok;
        private System.Windows.Forms.DataGridView dataGridView3;
        private MarketDbDataSet marketDbDataSet;
        private System.Windows.Forms.BindingSource urunlerBindingSource;
        private MarketDbDataSetTableAdapters.UrunlerTableAdapter urunlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunBarkodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kutuBasinaAdetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ındirimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kutuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
    }
}