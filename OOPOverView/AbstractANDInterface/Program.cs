// See https://aka.ms/new-console-template for more information
using AbstractANDInterface;

Console.WriteLine("Hello, World!");
PDFDocument pDF = new PDFDocument();
ExcelDocument excel = new ExcelDocument();

Printer printer = new Printer();
printer.Print(excel);