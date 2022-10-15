using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun()
            {
                Id = 1,
                UrunAdi = "Masa",
                Fiyat = 750
            };

            Urun urun2 = new Urun()
            {
                Id = 2,
                UrunAdi = "Bilgisayar",
                Fiyat = 8400
            };

            Urun urun3 = new Urun()
            {
                Id = 3,
                UrunAdi = "Televizyon",
                Fiyat = 6200
            };

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].Id + " : " + urunler[i].UrunAdi + " : " + urunler[i].Fiyat);
            }

            Console.WriteLine("---------------------");

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Id + " : " + urun.UrunAdi + " : " + urun.Fiyat);
            }

            Console.WriteLine("---------------------");


            int j = 0;
            while (j < urunler.Length)
            {
                Console.WriteLine(urunler[j].Id + " : " + urunler[j].UrunAdi + " : " + urunler[j].Fiyat);
                j++;
            }
        }
    }
}
