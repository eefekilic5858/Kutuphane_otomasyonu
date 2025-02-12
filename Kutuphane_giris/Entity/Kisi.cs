using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_giris.Entity
{
    public class Kisi
    {
        public int id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public DateTime olusturma_tarihi { get; set; }
        public string kullaniciadi { get; set; }
        public string sifre { get; set; }
        public string yetki { get; set; }

        public Kisi()
        {

        }

        public Kisi(int id, string ad, string soyad, DateTime olusturma_tarihi, string kullaniciadi, string sifre, string yetki)
        {
            this.id = id;
            this.ad = ad;
            this.soyad = soyad;
            this.olusturma_tarihi = olusturma_tarihi;
            this.kullaniciadi = kullaniciadi;
            this.sifre = sifre;
            this.yetki = yetki;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return this.id;
        }

        public void setAd(string ad)
        {
            this.ad = ad;
        }

        public string getAd()
        {
            return this.ad;
        }

        public void getSoyad(string soyad)
        {
            this.soyad = soyad;
        }

        public string getSoyad()
        {
            return this.soyad;
        }

        public void setOlusturmaTarihi(DateTime olusturma_tarihi)
        {
            this.olusturma_tarihi = olusturma_tarihi;
        }

        public DateTime getOlusturmaTarihi()
        {
            return this.olusturma_tarihi;
        }

        public void setkullaniciadi(string kullaniciadi)
        {
            this.kullaniciadi = kullaniciadi;
        }

        public string getkullaniciadi()
        {
            return this.kullaniciadi;
        }

        public void setSifre(string sifre)
        {
            this.sifre = sifre;
        }

        public string getSifre()
        {
            return this.sifre;
        }
        public void setYetki(string yetki)
        {
            this.yetki = yetki;
        }

        public string getYetki()
        {
            return this.yetki;
        }
        public override string ToString()
        {
            return "İsim: " + this.ad + " Soyisim: " + this.soyad;
        }
    }
}
