using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Musteri bilgileri elle girildi
            Musteri musteri1 = new Musteri() { TC = "12345678910", Ad = "Ali", Soyad = "Uzun", TelNo = "05331482038" };
            Musteri musteri2 = new Musteri() { TC = "55673260432", Ad = "Veli", Soyad = "Kısa", TelNo = "05436315858" };
            Musteri musteri3 = new Musteri() { TC = "12434652398", Ad = "Emre", Soyad = "Akıncı", TelNo = "05331428709" };
            Musteri musteri4 = new Musteri() { TC = "90856324510", Ad = "Engin", Soyad = "Demirog", TelNo = "05357320013" };
            Musteri musteri5 = new Musteri() { TC = "86546912387", Ad = "Ramiz", Soyad = "Karaeski", TelNo = "---" };

            //Musteri bilgileri bir yerde toplandi
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4, musteri5 };
            MusteriManager musteriManager = new MusteriManager();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nMusteriler sisteme ekleniyor...\n");
            Console.ResetColor();

            //Girilen bilgiler sisteme yüklendi
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);
            musteriManager.Ekle(musteri5);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nMusteri ekleme islemi tamamlandi!");
            Console.WriteLine("\n\n-----Musteri Bilgileri-----\n");
            Console.ResetColor();

            //Sistemdeki musteriler ve bilgileri listelendi
            musteriManager.Listele(musteriler);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nMusteriler sistemden siliniyor...\n");
            Console.ResetColor();


            //Bankamızla iliskisi kesilen musteriler sistemden silindi
            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri3);
            musteriManager.Sil(musteri4);
            musteriManager.Sil(musteri5);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nMusteri silme islemi tamamlandi!");
            Console.ResetColor();
        }
    }
}
