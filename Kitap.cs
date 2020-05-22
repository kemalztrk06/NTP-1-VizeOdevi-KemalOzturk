using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapEvi
{
    public class Kitap : Program
    {
        public Kitap()
        {

        }
        public Kitap(string kitapadi, string kitaptürü, string yazaradi, string basimtarihi)
        {
            this.KtpAdi = kitapadi;

            this.KtpTürü = kitaptürü;

            this.YzrAdi = yazaradi;

            this.BsmTarihi = basimtarihi;
        }
        private string kitapadi;

        private string kitaptürü;

        private string yazaradi;

        private string basimtarihi;


        public string KtpAdi { get => kitapadi; set => kitapadi = value; }

        public string KtpTürü { get => kitaptürü; set => kitaptürü = value; }

        public string YzrAdi { get => yazaradi; set => yazaradi = value; }

        public string BsmTarihi { get => basimtarihi; set => basimtarihi = value; }

        public string KtpGetir() => $" Kitap adı:{this.KtpAdi}, Kitap türü: {this.KtpTürü}, Yazar Adı: {this.YzrAdi} , Basım tarihi: {this.BsmTarihi}";


    }
}
