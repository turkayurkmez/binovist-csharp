// See https://aka.ms/new-console-template for more information
//LINQ
//Language INtegrated Query


using BasicLINQ;

var productService = new ProductService();

var allProducts = productService.GetProducts();
var allSuppliers = productService.Suppliers;

var products = from product in allProducts
               where product.Description.Contains("Android")
               orderby product.Price descending
               select new { product.Name, product.Price };


var olmayanTip = new { name = "Türkay", lastName = "Ürkmez" };
Console.WriteLine("=========  Extension Methods ==========");
var productsWithExtended = allProducts.Where(p => p.Description.Contains("Android"))
                                      .OrderByDescending(p => p.Price)
                                      .Select(p => new { ProductName = p.Name, ProductPrice = p.Price })
                                      .ToList();

productsWithExtended.ForEach(p => Console.WriteLine($"{p.ProductName}: {p.ProductPrice}"));

var firstProduct = allProducts.FirstOrDefault(p => p.Id == 3, new Product { Name = "NoResult", Description = "Böyle bir ürün yok" });

//var singleProduct = allProducts.SingleOrDefault(p => p.Name == "Samsung A51" && p.Description == "Android");

/*
 * Aggregates:
 */

var maxPrice = products.Max(p => p.Price);
var avgPrice = products.Average(p => p.Price);
var count = products.Count(p => p.Price < 1000);
var sum = products.Sum(p => p.Price);

Console.WriteLine($"Toplam ürün: {count}");
Console.WriteLine(firstProduct);



//products.ToList().ForEach(p => Console.WriteLine($"{p.Name}"));
Console.WriteLine("============ JOIN ===========");
var join = allSuppliers.Join(inner: allProducts,
                            outerKeySelector: supplier => supplier,
                            product => product.SupplierCompany,
                            resultSelector: (supplier, product) => new
                            {
                                CompanyName = supplier.Name,
                                ProductName = product.Name
                            }


                           );

foreach (var item in join)
{
    Console.WriteLine($"Tedarikçi: {item.CompanyName} - Ürün: {item.ProductName}");
}

var join2 = allProducts.Select(p => new { Name = p.Name, Company = p.SupplierCompany.Name })
                       .ToList();

Console.WriteLine("=========== Without Join ====");
join2.ForEach(pr => Console.WriteLine(pr.Name + " " + pr.Company));

Console.WriteLine("============== Group By ==========");

var group = allProducts.GroupBy(keySelector: product => product.SupplierCompany.Name,
                                elementSelector: product => new { product.Name, product.Price },
                                resultSelector: (comName, cProducts) => new
                                {
                                    CompanyName = comName,
                                    Count = cProducts.Count(),
                                    Min = cProducts.Min(m => m.Price),
                                    Max = cProducts.Max(m => m.Price),
                                    Avg = cProducts.Average(x => x.Price)
                                }
                                ).ToList();

group.ForEach(g => Console.WriteLine($"{g.CompanyName} Toplam ürün: {g.Count}, En pahalı {g.Max}"));

Console.WriteLine("Hello, World!");

