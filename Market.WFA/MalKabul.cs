using Market.BLL.Repository;
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

        private void lstUrunler_ContextMenuStripChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
                if(kategori.Urunler.Count>0)
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
            barkod.Show();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                new KategoriRepo().Insert(new Kategori()
                {
                    KategoriAdi = txtKategoriAdi.Text,
                    KDV = nudKDV.Value,
                    Kar=nudKar.Value
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
            urunId = (int)e.Node.Tag;
            kategoriId = (int)e.Node.Tag;
            urun = new UrunRepo().GetById(urunId);
            kategori = new KategoriRepo().GetById(kategoriId);
            txtKategoriAdi.Text = kategori.KategoriAdi;
            nudKar.Value = kategori.Kar;
            nudKDV.Value = kategori.KDV;

            if (urun == null) return;

            lblUrunBilgileri.Text= $"Ürün Adı:{urun.UrunAdi}\nBarkod No:{urun.UrunBarkod}\nBirim Fiyatı:{urun.BirimFiyat:c2}" + $"\nStok Miktarı:{urun.Stok} adet\nÜrün Kategorisi: {urun.Kategori}\nKutu Başına Adet:{urun.KutuBasinaAdet}";
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
    }
}
