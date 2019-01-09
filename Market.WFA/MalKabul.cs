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
        private void tvUrunler_AfterSelect(object sender, TreeViewEventArgs e)
        {
            urunId = (int)e.Node.Tag;
            kategoriId = (int)e.Node.Tag;
            urun = new UrunRepo().GetById(urunId);
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
