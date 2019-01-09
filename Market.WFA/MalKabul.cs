﻿using Market.BLL.Repository;
using Market.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.WFA
{
    public partial class MalKabul : Form
    {
        public MalKabul()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            this.ControlBox = false;
            KategorileriGetir();
        }
        public void KategorileriGetir()
        {
            tvUrunler.Nodes.Clear();
            var kategoriler = new KategoriRepo().GetAll().OrderBy(x => x.KategoriAdi).ToList();
            foreach (var kategori in kategoriler)
            {
                TreeNode node = new TreeNode(kategori.KategoriAdi);
                node.Tag = kategori.KategoriId;
                tvUrunler.Nodes.Add(node);
                if (kategori.Urunler.Count > 0)
                {
                    var urunler = new UrunRepo().GetAll(x => x.KategoriId == kategori.KategoriId).ToList();
                    foreach (var urun in urunler)
                    {
                        TreeNode subNode = new TreeNode(urun.UrunAdi);
                        subNode.ContextMenuStrip = cmsUrunIslemleri;
                        subNode.Tag = urun.UrunId;
                        node.Nodes.Add(subNode);
                    }
                }
            }
            tvUrunler.ExpandAll();
        }

        private void btnBarkodOku_Click(object sender, EventArgs e)
        {
            BarkodOkuma barkod = new BarkodOkuma();

            DialogResult cevap = barkod.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                UrunIslemleri urunIslemleri = new UrunIslemleri();
                urunIslemleri.Barkod(barkod.Barkod, barkod.KutuAdet);
                urunIslemleri.ShowDialog();
                KategorileriGetir();
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                new KategoriRepo().Insert(new Kategori()
                {
                    KategoriAdi = txtKategoriAdi.Text,
                    KDV = nudKDV.Value,
                    Kar = nudKar.Value
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            KategorileriGetir();
        }
        private int urunId;
        private int kategoriId;
        Urun urun;
        Kategori kategori;
        private void tvUrunler_AfterSelect(object sender, TreeViewEventArgs e)
        {           
            if (new UrunRepo().Queryable().FirstOrDefault(x=>x.UrunAdi==e.Node.Text)!=null)
            {
                urunId = (int)e.Node.Tag;
                urun = new UrunRepo().GetById((urunId));
                if (urun == null) return;
                lblUrunBilgileri.Text = $"Ürün Adı:{urun.UrunAdi}\nBarkod No:{urun.UrunBarkod}\nBirim Fiyatı:{urun.BirimFiyat:c2}" + $"\nStok Miktarı:{urun.Stok} adet\nÜrün Kategorisi: {urun.Kategori}\nKutu Başına Adet:{urun.KutuBasinaAdet}";
            }
            if (new KategoriRepo().Queryable().FirstOrDefault(x => x.KategoriAdi == e.Node.Text) != null)
            {
                kategoriId = (int)e.Node.Tag;
                kategori = new KategoriRepo().GetById(kategoriId);
                if (kategori == null) return;
                txtKategoriAdi.Text = kategori.KategoriAdi;
                nudKar.Value = kategori.Kar;
                nudKDV.Value = kategori.KDV;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var secilikategori = new KategoriRepo().Queryable().First(x => x.KategoriId == kategori.KategoriId);
            secilikategori.KategoriAdi = txtKategoriAdi.Text;
            secilikategori.KDV = nudKDV.Value;
            secilikategori.Kar = nudKar.Value;
            new KategoriRepo().Update();
            KategorileriGetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            new KategoriRepo().Delete(kategori);
            KategorileriGetir();
        }
        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunIslemleri urunIslemleri = new UrunIslemleri();
            urunIslemleri.Urun = urun;
            DialogResult cevap = urunIslemleri.ShowDialog();
            if (cevap == DialogResult.OK)
                KategorileriGetir();
        }
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var urun = new UrunRepo().Queryable().First(x => x.UrunId == urunId);
            new UrunRepo().Delete(urun);
            KategorileriGetir();
        }
    }
}
