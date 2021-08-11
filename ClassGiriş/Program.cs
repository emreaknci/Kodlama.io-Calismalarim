using System;

namespace ClassGiriş
{
    class Program
    {
        static void Main(string[] args)
        {
            Products product1 = new Products()
            {
                productName = "Huawei MateBook D16",
                productPrice = 8999,
                salesQuantity = 458,
                popularComment = "Yazılım öğrenmek için gerekli düzeyde bir laptop. Tavsiye ederim."
            };

            Products product2 = new Products()
            {
                productName = "Telefon",
                productPrice = 3800,
                salesQuantity = 858,
                popularComment = "Günlük işlerinizi fazlasıyla yerine getirebileceğiniz bir telefon. Kesinlikle alınmalı YTD."
            };

            Products product3 = new Products()
            {
                productName = "Tişört",
                productPrice = 79,
                salesQuantity = 1258,
                popularComment = "Bu fiyata daha kaliteli bir ürün beklerdim. İlk yıkamada XL'den M'a döndü... Rezalet."
            };

            Products[] products = new Products[]
            {
                product1,
                product2,
                product3
            };
            Console.WriteLine("----FOR DONGUSU----");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("\nUrun Adi: " + products[i].productName + "\nUrun Fiyati: " + products[i].productPrice +
                    "\nSatis Adedi: " + products[i].salesQuantity + "\nEn iyi yorum: " + products[i].popularComment);
            }

            int j = 0;

            Console.WriteLine("\n\n----WHILE DONGUSU----");
            while (j < products.Length)
            {
                Console.WriteLine("\nUrun Adi: " + products[j].productName + "\nUrun Fiyati: " + products[j].productPrice +
                    "\nSatis Adedi: " + products[j].salesQuantity + "\nEn iyi yorum: " + products[j].popularComment);
                j++;
            }
            Console.WriteLine("\n\n----FOREACH DONGUSU----");
            foreach (var product in products)
            {
                Console.WriteLine("\nUrun Adi: " + product.productName + "\nUrun Fiyati: " + product.productPrice +
                   "\nSatis Adedi: " + product.salesQuantity + "\nEn iyi yorum: " + product.popularComment);
            }
            

        }
        class Products
        {
            public string productName { get; set; }
            public int productPrice { get; set; }
            public int salesQuantity { get; set; }
            public string popularComment { get; set; }
        }
    }
}
