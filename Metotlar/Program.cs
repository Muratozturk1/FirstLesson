// See https://aka.ms/new-console-template for more information
using Metotlar;

Console.WriteLine("Hello, World!");

Product product1 = new Product();
product1.Name = "Elma";
product1.Price = 15;
product1.Description = "Amasya Elması";

Product product2 = new Product();
product2.Name = "Karpuz";
product2.Price = 80;
product2.Description = "Diyarbakır Karpuzu";

Product[] products = new Product[] { product1, product2 };
foreach (Product product in products)
{
    Console.WriteLine(product.Name);
    Console.WriteLine(product.Price);
    Console.WriteLine(product.Description);
    Console.WriteLine("*************");
}
Console.WriteLine("***********Metotlar**************");
//instance örnek
// encapsulation
SepetManager spt = new SepetManager();
spt.Add(product1);
spt.Add(product2);



