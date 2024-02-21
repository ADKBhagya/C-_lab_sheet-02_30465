using System;
namespace InventorySystem
{
    class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; 
        public Product(string productName, double price)
        {
            ProductName = productName;
            Price = price;
        }
    }
class Program
    {
        static void Main(string[] args)
        {
          
            Product product1 = new Product("PC", 200000);
            Product product2 = new Product("Smartphone", 30000);

            Console.WriteLine("Product 1:");
            Console.WriteLine("Name: " + product1.ProductName);
            Console.WriteLine("Price: Rs." + product1.Price);
            Console.WriteLine();

            Console.WriteLine("Product 2:");
            Console.WriteLine("Name: " + product2.ProductName);
            Console.WriteLine("Price: Rs." + product2.Price);
          
            Console.ReadLine(); 
        }
    }
}
