	using ConsoleApp1;
using System;
using static ConsoleApp1.ElectronicProduct;

namespace LabWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[]
            {
                new FoodProduct("A001", "Молоко", 150.0m, "Молочные продукты", 50, new DateTime(2026, 4, 30)),
                new ElectronicsProduct("A002", "Iphone 15", 54990.0m, "Электроника", 10, 12),
                new ClothingProduct("A003", "Куртка зимняя", 9000.0m, "Одежда", 25, "L")
            };

            foreach (Product product in products)
            {
                product.ShowInfo();

                if (product is IDiscountable discountable)
                {
                    if (product is FoodProduct)
                        discountable.ApplyDiscount(25); //лимит 30%
                    else if (product is ElectronicsProduct)
                        discountable.ApplyDiscount(20); //лимит 20%
                    else
                        discountable.ApplyDiscount(30); //без ограничений
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}