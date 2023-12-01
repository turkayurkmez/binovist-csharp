// See https://aka.ms/new-console-template for more information
using functionsAndLoops;

Console.WriteLine("Hello, World!");

string[] words = { "Çanakkale", "Eskişehir", "İstanbul", "Yozgat", "Bayburt", "Bilecik" };
var isFound = isFoundInArray("Giresun", words);
string response = isFound ? "var" : "yok";

Console.WriteLine($"Kelime liste içerisinde {response}");

Geometry geometry = new Geometry();
Console.WriteLine(geometry.GetArea(5, Shape.Square));
Console.WriteLine(geometry.GetArea(5, Shape.Circle));

//geometry.GetArea(5, Shape.Circle);

geometry.GetAreaOptional(unit1: 10);
geometry.GetAreaOptional(3, shape: Shape.Circle);
geometry.GetAreaOptional(unit1: 4, unit2: 8, shape: Shape.Triangle);





bool isFoundInArray(string word, string[] words)
{

    //int x = 0;
    //while (x< words.Length)
    //{

    //	x++;
    //}
    for (int i = 0; i < words.Length; i++)
    {
        if (words[i] == word)
        {
            return true;
        }

    }

    return false;
}

int getIndexOfWord(string word, string[] words)
{
    for (int i = 0; i < words.Length; i++)
    {
        if (words[i] == word)
        {
            return i;
        }

    }
    return -1;


}

bool isFoundInArrayWithForEach(string word, string[] words)
{

    //int x = 0;
    //while (x< words.Length)
    //{

    //	x++;
    //}
    foreach (var item in words)
    {
        if (item == word)
        {
            return true;
        }
    }

    return false;
}

bool isEven(int number)
{
    return number % 2 == 0;
}