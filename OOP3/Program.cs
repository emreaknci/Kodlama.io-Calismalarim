using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            ihtiyacKrediManager.Hesapla();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            tasitKrediManager.Hesapla();
            KonutKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();

            Console.WriteLine("\n-----------------------------------------\n");

            IKrediManager ihtiyacKrediManager1 = new IhtiyacKrediManager();
            //ihtiyacKrediManager1.Hesapla();
            IKrediManager tasitKrediManager1 = new TasitKrediManager();
            //tasitKrediManager1.Hesapla();
            IKrediManager konutKrediManager1 = new KonutKrediManager();
            //konutKrediManager1.Hesapla();


            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ihtiyacKrediManager1);
            //basvuruManager.BasvuruYap(tasitKrediManager1);
            //basvuruManager.BasvuruYap(konutKrediManager1);

            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();

            basvuruManager.BasvuruYap(konutKrediManager1, databaseLoggerService);
            basvuruManager.BasvuruYap(tasitKrediManager1, fileLoggerService);
            basvuruManager.BasvuruYap(new EsnafKrediManager(), new SMSLoggerService());
            
            Console.WriteLine("\n-----------------------------------------\n");
            
            
            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager1,tasitKrediManager1 };
            
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
