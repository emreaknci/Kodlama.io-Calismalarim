using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> isimler = new List<string>() { "ali", "veli" };
            isimler.Add("engin");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(isimler[i]);
            }
        }
    }
}
