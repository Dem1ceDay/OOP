using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ElectronicProduct
    {
        internal class ElectronicsProduct : Product, IDiscountable
        {
            private int _warrantyMonths;
            public int WarrantyMonths
            {
                get => _warrantyMonths;
                set => _warrantyMonths = value;
            }

            public ElectronicsProduct(string article, string name, decimal price, string category, int quantityInStock, int warrantyMonths)
                : base(article, name, price, category, quantityInStock)
            {
                _warrantyMonths = warrantyMonths;
            }

            public void ApplyDiscount(double percent)
            {
                if (percent > 20)
                {
                    Console.WriteLine($"Ошибка: для электроники скидка не может превышать 20% (сохранение гарантии)!");
                    return;
                }
                decimal discountAmount = Price * (decimal)percent / 100m;
                Price -= discountAmount;
                Console.WriteLine($"На электронику '{Name}' ({Articul}) применена скидка {percent}% (снижение на {discountAmount} руб.). Новая цена: {Price} руб.");
            }

            public override void ShowInfo()
            {
                base.ShowInfo();
                Console.WriteLine($"Гарантия: {WarrantyMonths} месяцев");
            }
        }
    }
}
