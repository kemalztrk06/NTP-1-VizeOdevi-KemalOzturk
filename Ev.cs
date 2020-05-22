using System;
using System.IO;

namespace proje
{
    class Ev
    {
        public Ev(int odasayisi,int katno, string semt, double alan)//varsayılan yapıcı method 
        {
            this.SetOdasayisi(odasayisi);
            this.katno = Katno;
            this.
        }

        private int odasayisi;
        private int katno;
        private string semt;
        private double alan;

        public int GetOdasayisi()
        {
            return odasayisi;
        }

        public void SetOdasayisi(int value)
        {
            if (value<0)
            {
                FileStream fs = new FileStream("C:\\OdaSayisiHatalari.txt", FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine($"Oda Sayısı Hatalı Girildi.Girilen Değer:{value}\r\n");
                fs.Flush();
                sw.Close();
                fs.Close();
            }
            odasayisi = Math.Abs(value);
        }

        public int Katno { get => katno; set => katno = value; }
        public double Alan { get => alan; set => alan = value; }
        public string Semt { get => semt; set => semt = value; }
        public string EvBilgileriGetir() => $"Odasayısı:{this.GetOdasayisi()}\nKat No:{this.Katno}\nSemt:{this.Semt}\nAlan:{this.Alan}";
    }
}