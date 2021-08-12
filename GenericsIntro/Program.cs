using System;

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
        }
    }
}
