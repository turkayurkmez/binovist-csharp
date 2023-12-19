// See https://aka.ms/new-console-template for more information
using BuiltInInterfaces;

Console.WriteLine("Hello, World!");
Product product = new() { Id = 1, Name = "Tişört", Rating = 4.6, Price = 150, Stock = 1000 };
Product product2 = new() { Id = 2, Name = "Kazak", Rating = 4.2, Price = 500, Stock = 150 };

Product product3 = new() { Id = 3, Name = "Hırka", Rating = 4.9, Price = 750, Stock = 375 };

ProductService productService = new ProductService();
productService.AddProduct(product);
productService.AddProduct(product2);
productService.AddProduct(product3);

productService.SortProducts();

foreach (var item in productService)
{
    Console.WriteLine($"{item.Name} - {item.Price} - {item.Rating} - {item.Stock}");
}



