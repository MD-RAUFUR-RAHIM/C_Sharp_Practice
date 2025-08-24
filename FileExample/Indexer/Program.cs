// See https://aka.ms/new-console-template for more information
using Indexer;

Console.WriteLine("Hello, World!");
ShoppingCart shoppingCart = new ShoppingCart();
shoppingCart.AddItem(new Item() { Name = "Cycle", Price = 4000 });
shoppingCart.AddItem(new Item() { Name = "Book", Price = 5000 });
var firstItem = shoppingCart._items[0];
var secondItem = shoppingCart[1];