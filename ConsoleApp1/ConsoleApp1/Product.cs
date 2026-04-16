using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
	public class Product
	{
		private string _Articul;
		private string _Name;
		private int _Price;
		private string _Category;
		private int _Volume;

        public Product(string Articul, string Name, int Price, string Category, int Volume)
        {
            _Articul = Articul;
            _Name = Name;
            _Price = Price;
            _Category = Category;
            _Volume = Volume;
        }
		public string Articul
		{
			get => _Articul;
			set => _Articul = value;
		}
		public string Name
		{
			get => _Name;
			set => _Name = value;
		}
		public int Price
		{
			get => _Price;
			set => _Price = value;
		}
		public string Category
		{
			get => _Category;
			set => _Category = value;
		}
		public int Volume
		{
			get => _Volume;
			set => _Volume = value;
		}
		public bool MinusVolume(int amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Количество для списания должно быть больше 0.");
                return false;
            }
            if (Volume < amount) 
            {
                Console.WriteLine($"Недостаточно товара. На складе: {Volume}, запрашивыается {amount}.");
                return false;
            }

            Volume-=amount;
            Console.WriteLine($"Успешно списано {amount} единиц товара {Name}. Остоток: {Volume}.");
            return true;
        }

        public bool PlusVolume(int amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Количество для поставки должно быть больше 0.");
                return false;
            }

            Volume += amount;
            Console.WriteLine($"Успешно поставлено {amount} единиц товара {Name}. Остоток: {Volume}.");
            return true;
        }
       
        public void Print()
		{
			Console.WriteLine($"Артикул {Articul} ");
			Console.WriteLine($"Имя {Name} ");
			Console.WriteLine($"Цена {Price} руб");
			Console.WriteLine($"Категория {Category} ");
			Console.WriteLine($"Количество {Volume} ");
            Console.WriteLine();

        }
	}
}
