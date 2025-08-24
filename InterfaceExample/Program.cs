using InterfaceExample;

//IEmail email = new TextEmail();
//Membership membership= new Membership(email);
//membership.SignUp("abc@1234", "1234");
IAnimal dog = new Dog();
Dog dog1 = new Dog();
dog1.Eat();
dog1.MakeSound();
IAnimal cat = new Cat();
Cat cat1 = new Cat();
cat1.Eat();
cat1.MakeSound();