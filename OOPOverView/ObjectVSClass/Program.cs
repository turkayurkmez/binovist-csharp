// See https://aka.ms/new-console-template for more information
using ObjectVSClass;

Console.WriteLine("Hello, World!");

Person developer1 = new Person();
developer1.Name = "Türkay";
developer1.Age = 43;

Person developer2 = new Person();
developer2 = developer1;
developer2.Name = "Seçkin";

Console.WriteLine(developer1.Name);
Console.WriteLine(developer2.Name);


//int x = 5;
//proofReference(ref x, developer2);
//Console.WriteLine($"main scope'unda.{x}");
//Console.WriteLine(developer2.Name + "... main");


////Türkay +++++
////Seçkin + 

//void proofReference(ref int value, Person p)
//{
//    value *= 2;
//    Console.WriteLine($"metot scope'unda.{value}");
//    p.Name = "Metot Scope";
//    Console.WriteLine(p.Name + "... metot");
//}

