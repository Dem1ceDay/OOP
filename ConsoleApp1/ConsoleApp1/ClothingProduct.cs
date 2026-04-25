using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClothingProduct : Product, IDiscountable
    {
            private string _size;
            public string Size
            {
                get => _size;
                set => _size = value;
            }

            public ClothingProduct(string article, string name, decimal price, string category, int quantityInStock, string size)
                : base(article, name, price, category, quantityInStock)
            {
                _size = size;
            }

            public void ApplyDiscount(double percent)
            {
                decimal discountAmount = Price * (decimal)percent / 100m;
                Price -= discountAmount;
                Console.WriteLine($"На одежду '{Name}' (размер {Size}, {Articul}) применена скидка {percent}% (снижение на {discountAmount} руб.). Новая цена: {Price} руб.");
            }

            public override void ShowInfo()
            {
                base.ShowInfo();
                Console.WriteLine($"Размер: {Size}");
            }
        }
    }
