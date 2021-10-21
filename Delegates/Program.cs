using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        public delegate void MyDelegate();
        public delegate void MyDelegate2(string text);
        public delegate int MyDelegate3(int number1,int number2);

        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            //MyDelegate myDelegate = customerManager.SendMessage;
            //myDelegate += customerManager.ShowAlert;
            //myDelegate -= customerManager.ShowAlert;
            //myDelegate();


            //MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            //myDelegate2 += customerManager.ShowAlert2;
            //myDelegate2("merhaba");

            Matematik mat = new Matematik();
            //MyDelegate3 myDelegate3 = mat.Topla;
            //myDelegate3 += mat.Carp;
            //Console.WriteLine(myDelegate3(2, 3)); 

            //Func<int, int, int> Add = mat.Topla;
            //Console.WriteLine(Add(3,5));

            //Func<int> getRandomNumber = delegate ()
            //{
            //    Random random = new Random();
            //    return random.Next(1, 100);
            //};
            //Console.WriteLine(getRandomNumber());

            //Func<int> getRandomNumber2 = () => new Random().Next(1, 50);
            //Console.WriteLine(getRandomNumber2());
                
            Console.ReadLine();
        }
    }
    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello!");
        }
        public void ShowAlert()
        {
            Console.WriteLine("Be careful!");
        }

        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }
        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }

    }
    class Matematik
    {
        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}
