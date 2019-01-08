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
    public partial class UrunIslemleri : Form
    {
        public UrunIslemleri()
        {
            InitializeComponent();
        }

        private void UrunIslemleri_Load(object sender, EventArgs e)
        {
            var kategoriler = new KategoriRepo().GetAll().ToList();
            cbKategori.DataSource = kategoriler;
        }
        int kutuAdet;
        public void Barkod(string brk,int adet)
        {
            txtBarkodNo.Text = brk;
            kutuAdet = adet;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var secili = cbKategori.SelectedItem as Kategori;

            try
            {
                new UrunRepo().Insert(new Urun()
                {
                    UrunAdi = txtUrunAdi.Text,
                    BirimFiyat = nudBirimFiyat.Value,
                    KutuBasinaAdet = Convert.ToInt32(nudKutuBasinaAdet.Value),
                    UrunBarkod = txtBarkodNo.Text,
                    KategoriId = secili.KategoriId,
                    Kutu=kutuAdet
                    
                });


                MessageBox.Show("Ürün kaydı başarılı");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
