	using ConsoleApp1;


string Articul = "123123232212",
Name = "Шубка Норковая",
Category = "Верхняя одежда";
int Price = 109990,
Volume = 7000;

Product SHUBA = new Product(Articul, Name, Price, Category, Volume);
SHUBA.Print();
SHUBA.MinusVolume(2000);
SHUBA.Print();
SHUBA.PlusVolume(1000);
SHUBA.Print();