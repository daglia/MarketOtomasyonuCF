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
                    foreach (var urunler in kategori.Urunler)
                    {
                        TreeNode subNode = new TreeNode(urunler.UrunAdi);
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
        private int? kategoriId;
        private void tvUrunler_AfterSelect(object sender, TreeViewEventArgs e)
        {
            kategoriId = (int)e.Node.Tag;
            var kategori = new KategoriRepo().GetById(kategoriId.Value);
        }
    }
}
