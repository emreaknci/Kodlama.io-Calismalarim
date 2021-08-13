using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("emre");
            Console.WriteLine("isimler.Count = " +isimler.Count);
            isimler.Add("yunus");
            Console.WriteLine("isimler.Count = " + isimler.Count);
            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }
            
            Dictionary<int, string> Ogrenci = new Dictionary<int, string>();
            Ogrenci.Add(134, "Tolga Demirer");
            Ogrenci.Add(158, "Ümit Özkan");
            Ogrenci.Add(115, "Kadir Aydemir");
            Ogrenci.Add(174, "Cemal Çiftçi");

            Console.Write("Öğrenci No Giriniz:");
            int No = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(Ogrenci[No]);
            }
            catch
            {
                Console.WriteLine("Öğrenci Bulunamadı.");
            }
            Dictionary<int, string>.KeyCollection AnahtarListesi = Ogrenci.Keys;
            foreach (int Anahtar in AnahtarListesi)
                Console.WriteLine(Anahtar);

            Dictionary<int, string>.ValueCollection DegerListesi = Ogrenci.Values;
            foreach (string Deger in DegerListesi)
                Console.WriteLine(Deger);

            foreach (KeyValuePair<int, string> veri in Ogrenci)
                Console.WriteLine("Numara:{0} - İsim:{1}", veri.Key, veri.Value);
        }
    }
}
