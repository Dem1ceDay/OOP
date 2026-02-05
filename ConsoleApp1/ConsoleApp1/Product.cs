using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Product
	{
		public string Articul { get; set; }
		public string Name { get; set; }
		public string Price { get; set; }
		public string Category { get; set; }
		public int Volume { get; set; }
		public void Print()
		{
			Console.WriteLine($"Артикул {Articul} ");
			Console.WriteLine($"Имя {Name} ");
			Console.WriteLine($"Цена {Price} ");
			Console.WriteLine($"Категория {Category} ");
			Console.WriteLine($"Количество {Volume} ");
		}
	}
}
