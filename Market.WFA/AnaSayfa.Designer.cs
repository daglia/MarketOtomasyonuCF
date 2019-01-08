namespace Market.WFA
{
    partial class AnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.malKabulİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dışarıAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFDosyasıOlarakAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelDosyasıOlarakAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(676, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.satışİşlemleriToolStripMenuItem,
            this.malKabulİşlemleriToolStripMenuItem,
            this.raporİşlemleriToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // satışİşlemleriToolStripMenuItem
            // 
            this.satışİşlemleriToolStripMenuItem.Name = "satışİşlemleriToolStripMenuItem";
            this.satışİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.satışİşlemleriToolStripMenuItem.Text = "Satış İşlemleri";
            this.satışİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.satışİşlemleriToolStripMenuItem_Click);
            // 
            // malKabulİşlemleriToolStripMenuItem
            // 
            this.malKabulİşlemleriToolStripMenuItem.Name = "malKabulİşlemleriToolStripMenuItem";
            this.malKabulİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.malKabulİşlemleriToolStripMenuItem.Text = "Mal Kabul İşlemleri";
            this.malKabulİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.malKabulİşlemleriToolStripMenuItem_Click);
            // 
            // raporİşlemleriToolStripMenuItem
            // 
            this.raporİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raporGörüntüleToolStripMenuItem,
            this.dışarıAktarToolStripMenuItem});
            this.raporİşlemleriToolStripMenuItem.Name = "raporİşlemleriToolStripMenuItem";
            this.raporİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.raporİşlemleriToolStripMenuItem.Text = "Rapor İşlemleri";
            // 
            // raporGörüntüleToolStripMenuItem
            // 
            this.raporGörüntüleToolStripMenuItem.Name = "raporGörüntüleToolStripMenuItem";
            this.raporGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.raporGörüntüleToolStripMenuItem.Text = "Rapor Görüntüle";
            this.raporGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.raporGörüntüleToolStripMenuItem_Click);
            // 
            // dışarıAktarToolStripMenuItem
            // 
            this.dışarıAktarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pDFDosyasıOlarakAktarToolStripMenuItem,
            this.excelDosyasıOlarakAktarToolStripMenuItem});
            this.dışarıAktarToolStripMenuItem.Name = "dışarıAktarToolStripMenuItem";
            this.dışarıAktarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dışarıAktarToolStripMenuItem.Text = "Dışarı Aktar";
            // 
            // pDFDosyasıOlarakAktarToolStripMenuItem
            // 
            this.pDFDosyasıOlarakAktarToolStripMenuItem.Name = "pDFDosyasıOlarakAktarToolStripMenuItem";
            this.pDFDosyasıOlarakAktarToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.pDFDosyasıOlarakAktarToolStripMenuItem.Text = "PDF Dosyası Olarak Aktar";
            // 
            // excelDosyasıOlarakAktarToolStripMenuItem
            // 
            this.excelDosyasıOlarakAktarToolStripMenuItem.Name = "excelDosyasıOlarakAktarToolStripMenuItem";
            this.excelDosyasıOlarakAktarToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.excelDosyasıOlarakAktarToolStripMenuItem.Text = "Excel Dosyası Olarak Aktar";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Market.WFA.Properties.Resources.content_20_ekim_2017_cuma_bim_aktuel_urunler_katalogu_bu_hafta_indirim_10ukU5EuiC370Vk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(676, 445);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnaSayfa";
            this.Text = "AnaSayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem malKabulİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dışarıAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDFDosyasıOlarakAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelDosyasıOlarakAktarToolStripMenuItem;
    }
}