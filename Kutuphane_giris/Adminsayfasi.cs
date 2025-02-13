using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kutuphane_giris.Entity;

namespace Kutuphane_giris
{
    public partial class Adminsayfasi : Form
    {
        List<Kisi> kisilerim;
        List<Kitap> kitaplarim;
        public Adminsayfasi(List<Kisi> kisilerim, List<Kitap> kitaplarim)
        {
            InitializeComponent();
            this.kisilerim = kisilerim;
            this.kitaplarim = kitaplarim;

        }

       

       

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Adminsayfasi_Load(object sender, EventArgs e)
        {
           
            

            foreach (Kisi kisi in kisilerim)
            {
                dataGridView1.Rows.Add(kisi.getId(), kisi.getAd(), kisi.getSoyad(), kisi.getOlusturmaTarihi(), kisi.getkullaniciadi(), kisi.getSifre(), kisi.getYetki());
            }

            foreach (Kitap kitap in kitaplarim)
            {
                dataGridView2.Rows.Add(kitap.getKitapId(),kitap.getKitapAdi(),kitap.getKitapYazari(), kitap.getKitapdili(), kitap.getKitapYayinevi(), kitap.getKitapturu(), kitap.getSayfaSayisi(), kitap.getBasimyili());
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txt_id.Text, txt_isim.Text, txt_soyisim.Text, DateTime.Now, txt_kullaniciadi.Text, txt_sifre.Text, txt_yetki.Text);
        }

        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }
        public void textleridoldur()
        {
            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_isim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_soyisim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_kullaniciadi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_sifre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_yetki.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textleridoldur();  

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            
           string id = txt_id.Text;
            string isim = txt_isim.Text;
            string soyisim = txt_soyisim.Text;
            string kullaniciadi = txt_kullaniciadi.Text;
            string sifre = txt_sifre.Text;
            string yetki = txt_yetki.Text;
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(id, isim, soyisim, DateTime.Now, kullaniciadi, sifre, yetki);


        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i< groupBox1.Controls.Count;i++)
            {
                if (groupBox1.Controls[i] is TextBox || groupBox1.Controls[i] is MaskedTextBox)
                {
                    groupBox1.Controls[i].Text = string.Empty;
                }
            }
        }

        private void btn_kitapekle_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(txt_kitapid.Text, txt_kitapisim.Text, txt_kitapyazar.Text, txt_kitapdil.Text,txt_yayinevi.Text, txt_kitaptur.Text, txt_kitapadet.Text, txt_kitapsayfa.Text);
        }

        private void btn_kitapsil_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
        }

        private void btn_kitapguncelle_Click(object sender, EventArgs e)
        {

        }

        private void btn_kitaptemizle_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kitapid.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txt_kitapisim.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txt_kitapyazar.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txt_kitapdil.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txt_yayinevi.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            txt_kitaptur.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            txt_kitapadet.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            txt_kitapsayfa.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();



        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
