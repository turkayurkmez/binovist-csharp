﻿// See https://aka.ms/new-console-template for more information
using Encapsulation;

Console.WriteLine("Hello, World!");

Product product = new Product();
Console.WriteLine("fiyat gir");
var price = -10.0;

product.SetPrice(price);
product.Name = "Rayban Gözlük";

product.Description = "2024 Yaz sezonu";
product.UpdateStock(45);