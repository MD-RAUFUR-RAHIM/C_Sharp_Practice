using ClassExample;

//Product product = new Product("Laptop", 40.4);
//product.price = 10.9;
//product.name = "Maruf khan";
//string name= product.GetUrlFriendName();
//Console.WriteLine(name);
//double price = product.GetRoundedPrice();
//Console.WriteLine(price);
Product product = new Product(5,10,40);
Console.WriteLine(product.name);
Camera camera = new Camera();
camera.name = "Hello Fooking World";
string name = camera.GetUrlFriendName();
Console.WriteLine(name);
Console.WriteLine(camera);