using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FoodProduct : Product, IDiscountable
    {
            private DateTime _expirationDate;
            public DateTime ExpirationDate
            {
                get => _expirationDate;
                set => _expirationDate = value;
            }

            public FoodProduct(string Articul, string Name, decimal Price, string category, int quantityInStock, DateTime expirationDate)
                : base(Articul, Name, Price, category, quantityInStock)
            {
                _expirationDate = expirationDate;
            }

            public void ApplyDiscount(double percent)
            {
                if (percent > 30)
                {
                    Console.WriteLine($"Ошибка: для продуктов питания скидка не может превышать 30%!");
                    return;
                }
                decimal discountAmount = Price * (decimal)percent / 100m;
                Price -= discountAmount;
                Console.WriteLine($"На продукт '{Name}' ({Articul}) применена скидка {percent}% (снижение на {discountAmount} руб.). Новая цена: {Price} руб.");
            }

            public override void ShowInfo()
            {
                base.ShowInfo();
                Console.WriteLine($"Срок годности: {ExpirationDate:dd.MM.yyyy}");
        }
    }
}
