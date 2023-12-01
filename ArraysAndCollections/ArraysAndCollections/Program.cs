// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] days = new string[7];
string[] turkishDays = { "Pazartesi", "Salı" };


string[] birler = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
string[] onlar = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };


do
{
    Console.WriteLine("Bir sayı giriniz:");
    int number;
    if (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Lütfen sadece sayıdal değer girin");
    }

    int birlerBasamakDegeri = number % 10;
    int onlarBasamakDegeri = number / 10;

    string yazim = onlar[onlarBasamakDegeri] + birler[birlerBasamakDegeri];
    Console.WriteLine(yazim);
    Console.WriteLine("Bir sayı daha (E/H)?");
} while (Console.ReadLine() == "E");

List<string> list = new List<string>();

//object o = "deneme";
//string value = (string)o;

//42
//Kırk iki

