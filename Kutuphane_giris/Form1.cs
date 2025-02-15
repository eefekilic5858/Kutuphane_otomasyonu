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
    public partial class Form1 : Form
    {
        List<Kisi> kisilerim = new List<Kisi>();
        List<Kitap> kitaplarim = new List<Kitap>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kisilerim.Add(new Kisi(1, "Ahmet", "Yılmaz", DateTime.Now, "ahmet", "123", "admin"));
            kisilerim.Add(new Kisi(2, "Efe", "Kılıç", DateTime.Now, "efe", "123", "admin"));
            kisilerim.Add(new Kisi(3, "Mehmet", "Yıldırım", DateTime.Now, "mehmet", "123", "uye"));

            kitaplarim.Add(new Kitap(3, "Kürk Mantolu Madonna", "Sabahattin Ali", "Türkçe", "Yapı Kredi Yayınları", "Roman", 194, 897, 2018));
            kitaplarim.Add(new Kitap(4, "Harry Potter ve Felsefe Taşı", "J.K. Rowling", "Türkçe", "Yapı Kredi Yayınları", "Fantastik", 1997, 276, 2021));
            kitaplarim.Add(new Kitap(5, "Beyaz Zambaklar Ülkesinde", "Grigory Petrov", "Türkçe", "Koridor Yayıncılık", "Eğitim", 1923, 220, 2020));
            kitaplarim.Add(new Kitap(6, "Yeraltından Notlar", "Dostoyevski", "Türkçe", "İş Bankası", "Felsefi Roman", 1864, 112, 2015));

        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_kullaniciadi.Text = string.Empty;
            txt_sifre.Text = string.Empty;
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            string kullaniciadi = txt_kullaniciadi.Text;
            string sifre = txt_sifre.Text;
            bool kontrol = false;

            foreach (Kisi kisi in kisilerim)
            {
                if (kullaniciadi.ToLower() == kisi.getkullaniciadi() && sifre.ToLower() == kisi.getSifre())
                {
                    if (kisi.getYetki() == "admin")
                    {
                        Adminsayfasi adminssayfa = new Adminsayfasi(kisilerim, kitaplarim);

                        adminssayfa.Show();
                    }
                    else if (kisi.getYetki() == "uye")
                    {
                        Uyesayfasi uyesayfa = new Uyesayfasi();
                        uyesayfa.Show();
                    }

                    this.Hide();
                    kontrol = true;
                    break;
                }
            }

            // Eğer hiçbir eşleşme bulunamazsa hata mesajı göster
            if (!kontrol)
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_kullaniciadi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
