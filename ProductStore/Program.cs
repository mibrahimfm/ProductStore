// See https://aka.ms/new-console-template for more information

using ProductStore;

var p1 = ProductRepository.Instance;
var p2 = ProductRepository.Instance;

p1.AddProduct("Microwave");
p2.AddProduct("Fridge");
p2.AddProduct("Stove");

Console.WriteLine($"P1 and P2 are the same: {p1 == p2}");
p1.DisplayProducts();