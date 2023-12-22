// See https://aka.ms/new-console-template for more information
using ExtensionsMethods;

Console.WriteLine("Hello, World!");

//varolan tiplere ihtiyaç duyduğunuz fonksiyonları ekleyebilirsiniz.
int x = 5;
Console.WriteLine(x.GetSquare());
Console.WriteLine(x.GetPower(3));

string name = "ahmet mümtaz taylan";

Console.WriteLine(name.ToTitleCase());
Console.WriteLine(new Random().NextWord(6));

