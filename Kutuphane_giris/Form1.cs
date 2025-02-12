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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kisilerim.Add(new Kisi(1, "Ahmet", "Yılmaz", DateTime.Now, "ahmet", "123", "admin"));
            kisilerim.Add(new Kisi(2, "Efe", "Kılıç", DateTime.Now, "efe", "123", "uye"));
            kisilerim.Add(new Kisi(3, "Mehmet", "Yıldırım", DateTime.Now, "mehmet", "123", "uye"));
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_kullaniciadi.Text = string.Empty;
            txt_sifre.Text = string.Empty;
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            string kullaniciadi, sifre = "";
            kullaniciadi = txt_kullaniciadi.Text;
            sifre = txt_sifre.Text;

            foreach (Kisi kisi in kisilerim)
            {
                if (kullaniciadi.ToLower() == kisi.getkullaniciadi() && sifre.ToLower() == kisi.getSifre() && kisi.getYetki() == "admin")
                {
                    Adminsayfasi adminssayfa = new Adminsayfasi();
                    adminssayfa.Show();
                    this.Hide();
                    break;
                }
                else if (kullaniciadi.ToLower() == kisi.getkullaniciadi() && sifre.ToLower() == kisi.getSifre() && kisi.getYetki() == "uye")
                {
                    Uyesayfasi uyesayfa = new Uyesayfasi();
                    uyesayfa.Show();
                    this.Hide();
                    break;
                }
                else
                {
                    MessageBox.Show("Bir hata oluştu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                break;



            }
        }
    }

}
