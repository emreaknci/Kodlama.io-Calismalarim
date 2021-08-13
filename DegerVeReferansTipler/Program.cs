using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10, sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine("sayi1: " + sayi1); //30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;

            sayilar2[0] = 999;
            Console.WriteLine("sayilar1[0]: " + sayilar1[0]); //999

            //int, double, bool ... değer tip
            //diziler, class, abstract class , interface... referans tip




        }
    }
}
