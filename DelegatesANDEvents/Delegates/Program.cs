// See https://aka.ms/new-console-template for more information
using Delegates;

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//.net 1.0 (2001)
var evenNumbersResult = FilterHelper.Filter(numbers, isEven);
show(evenNumbersResult);
Console.WriteLine("========== Tek Sayılar ==========");
//.net 2.0 (2006)
var oddNumbers = FilterHelper.Filter(numbers, delegate (int value) { return value % 2 == 1; });
show(oddNumbers);

//.net 3.5 (2010)
Console.WriteLine("=========== 3'ün katları =========");
var multiplyThree = FilterHelper.Filter(numbers, x => x % 3 == 0);
show(multiplyThree);
Console.WriteLine("Hello, World!");

//.net 4.0 (2012)



bool isEven(int number)
{
    return number % 2 == 0;
}

void show(int[] evenNumbersResult)
{
    foreach (var item in evenNumbersResult)
    {
        Console.WriteLine(item);
    }
}

void alternativeShow(int[] numbers) => numbers.ToList().ForEach(p => Console.WriteLine(p));
