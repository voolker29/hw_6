using task_classes;
///Создаем продукты
var apple = new Product() { Id = "Яблоко", Count = 20, Price = 100 };//2000
var orange = new Product("Апельсин",50,150) ;//7500
var banana = new Product("Банан", 10, 300);//3000
///Добаляем в интвентарь
var stock = new Inventory(apple, orange, banana);
//Смотрим 
stock.ShowProductList();
SplitConsole();
//Еще добавим
stock.AddProduct(new Product("Мандарин", 2, 3));//6
stock.ShowProductList();
SplitConsole();
////Посчитаем
Console.WriteLine(stock.GetAllProductSumm());//12506
Console.WriteLine(stock.GetProductSumm("Мандарин"));
Console.WriteLine(stock.GetProductSumm(orange));
SplitConsole();
//ИщемВозвращаетList
var result = stock.SearchProduct("Банан");
foreach (var item in result)
{ 
Console.WriteLine($"{item.Id} {item.Price} {item.Count}");

}


void SplitConsole ()
{
    Console.WriteLine(new string('-', 15));

}

