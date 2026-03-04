	using ConsoleApp1;


string Articul = "123123232212",
Name = "Шубка Норковая",
Price = "110000",
Category = "Верхняя одежда";
int Volume = 7000,	amount = 2000;

Product SHUBA = new Product(Articul, Name, Price, Category, Volume);
SHUBA.Print();
SHUBA.MinusVolume(2000);
SHUBA.Print();
SHUBA.PlusVolume(1000);
SHUBA.Print();