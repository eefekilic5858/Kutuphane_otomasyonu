using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_giris.Entity
{
    public class Kitap
    {
        public int kitapId { get; set; }
        public string kitapAdi { get; set; }
        public string kitapYazari { get; set; }
        public string kitapdili { get; set; }
        public string kitapYayinevi { get; set; }
        public string kitapturu { get; set; }
        public int adet { get; set; }
        public int sayfaSayisi { get; set; }
        public int basimyili { get; set; }

        public Kitap()
        {

        }

        public Kitap(int kitapId, string kitapAdi, string kitapYazari, string kitapdili, string kitapYayinevi, string kitapturu, int adet, int sayfaSayisi, int basimyili)
        {
            this.kitapId = kitapId;
            this.kitapAdi = kitapAdi;
            this.kitapYazari = kitapYazari;
            this.kitapdili = kitapdili;
            this.kitapYayinevi = kitapYayinevi;
            this.kitapturu = kitapturu;
            this.adet = adet;
            this.sayfaSayisi = sayfaSayisi;
            this.basimyili = basimyili;
        }

        public int getKitapId()
        {
            return this.kitapId;
        }

        public void setKitapId(int kitapId)
        {
            this.kitapId = kitapId;
        }

        public string getKitapAdi()
        {
            return this.kitapAdi;
        }

        public void setKitapAdi(string kitapAdi)
        {
            this.kitapAdi = kitapAdi;
        }

        public string getKitapYazari()
        {
            return this.kitapYazari;
        }

        public void setKitapYazari(string kitapYazari)
        {
            this.kitapYazari = kitapYazari;
        }

        public string getKitapdili()
        {
            return this.kitapdili;
        }

        public void setKitapdili(string kitapdili)
        {
            this.kitapdili = kitapdili;
        }

        public string getKitapYayinevi()
        {
            return this.kitapYayinevi;
        }

        public void setKitapYayinevi(string kitapYayinevi)
        {
            this.kitapYayinevi = kitapYayinevi;
        }

        public string getKitapturu()
        {
            return this.kitapturu;
        }

        public void setKitapturu(string kitapturu)
        {
            this.kitapturu = kitapturu;
        }

        public int getAdet()
        {
            return this.adet;
        }

        public void setAdet(int adet)
        {
            this.adet = adet;
        }

        public int getSayfaSayisi()
        {
            return this.sayfaSayisi;
        }

        public void setSayfaSayisi(int sayfaSayisi)
        {
            this.sayfaSayisi = sayfaSayisi;
        }

        public int getBasimyili()
        {
            return this.basimyili;
        }

        public void setBasimyili(int basimyili)
        {
            this.basimyili = basimyili;
        }
    }
}
