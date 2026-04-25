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
		private decimal _Price;
		private string _Category;
		private int _Volume;

        public Product(string Articul, string Name, decimal Price, string Category, int Volume)
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
		public decimal Price
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
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Артикул: {Articul}, Название: {Name}, Цена: {Price} руб.");
            Console.WriteLine($"Категория: {Category}, На складе: {Volume} шт.");
        }
    }
}
