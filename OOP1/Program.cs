using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product() { ID = 1, CategoryID = 2, ProductName = "Telefon", UnitPrice = 3799, UnitInStock = 1000 };
            Product product2 = new Product() { ID = 2, CategoryID = 5, ProductName = "Laptop", UnitPrice = 8999, UnitInStock = 849 };

        }
    }
}
