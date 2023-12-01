// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Primitive Types:

/*
 * Sayısal
 *   - Tam Sayılar
 *   - Ondalıklı Sayılar
 *   
 * Sözel
 *   
 * 
 * Mantıksal
 * 
 */

int x = 5;

//
byte max = 255;
sbyte min = -128;

short value1 = 32767;
ushort value2 = 65535;

int value3 = 1000000;

long value4 = 50000000000;
ulong value5 = 18446744073709551615;

double pi = 3.14d;
float fPi = 3.14f;
decimal dPi = 3.14m;

var rate = 4.2;

char c = 'C';
string s = "string";
String s2 = "string";

try
{
    Console.WriteLine("Bir sayı girin");
    int b1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Bir sayı daha girin");
    var b2 = Convert.ToInt32(Console.ReadLine());
    checked
    {
        byte b3 = (byte)(b1 / b2);
        Console.WriteLine(b3);
    }
}
catch (FormatException)
{
    Console.WriteLine("Lütfen sadece sayısal değer girin");
}
catch (OverflowException)
{
    Console.WriteLine("Değerler byte alanının üstünde!");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}






