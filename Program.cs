using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KitapEvi
{
    public class Program
    {
        static void Main(string[] args)
        {
            Kitap[] kitapevi = new Kitap[0];
            string cikis = "";
            while (cikis != "E")
            {
                Console.WriteLine("Kütüphanemize Hoşgeldiniz!");
                Console.WriteLine("Kitap ekleme işlemini yapmak için /1/ tuşuna basınız.");
                Console.WriteLine("Kitap Listesini görüntüleyebilmek için /2/ tuşuna basınız.");
                int liste = int.Parse(Console.ReadLine());
                if (liste == 1)
                {
                    Console.WriteLine("Kaç adet kitap girmek istediğinizi yazınız.");
                    int KitapSecim = int.Parse(Console.ReadLine());
                    kitapevi = new Kitap[KitapSecim];
                    for (int i = 0; i < KitapSecim; i++)
                    {
                        Kitap kitap1 = new Kitap();
                        Console.WriteLine("Lütfen {0}. kitap bilgilerini girin.", i + 1);
                        Console.Write($"Kitabın Adı:");
                        kitap1.KtpAdi = Console.ReadLine();
                        Console.Write($"Kitabın Türü:");
                        kitap1.KtpTürü = Console.ReadLine();
                        Console.Write($"Kitabın yazarının adı:");
                        kitap1.YzrAdi = Console.ReadLine();
                        Console.Write($"Kitabın basım yılı:");
                        kitap1.BsmTarihi = Console.ReadLine();
                        Console.WriteLine("_________________________________________________");
                        kitapevi[i] = kitap1;
                    }

                }
                else if (liste == 2)
                {
                    Kitap kitap = new Kitap();

                    Console.WriteLine(kitap.KtpGetir());
                }
                else
                {
                    Console.WriteLine("\n Hatalı girdiniz! Sadece 1 veya 2 kabul edilmektedir.");
                }
            }

        }
    }
}
