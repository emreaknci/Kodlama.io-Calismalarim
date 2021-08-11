using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " ve bilgileri sistemimize basarili bir sekilde eklendi!");
        }
        public void Listele(Musteri[] musteriler)
        {
            Console.WriteLine("TC No\t\tAd\t\tSoyad\t\tTelefon No\n");

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.TC + "\t" + musteri.Ad + "\t\t" + musteri.Soyad + "\t\t" + musteri.TelNo);
            }
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " ve bilgileri basarili bir sekilde sistemimizden silindi!");
        }
    }
}
