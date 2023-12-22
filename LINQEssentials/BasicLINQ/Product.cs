using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLINQ
{


    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Supplier SupplierCompany { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Description} - {Price}";
        }

    }

    public class ProductService
    {

        public List<Supplier> Suppliers { get; set; }

        private List<Product> products;

        public ProductService()
        {
            Suppliers = new List<Supplier> {
                new() {  Id=1, Name="Vatan Bilgisayar"},
                new() {  Id=2, Name="LCW"},

            };

            products = new() {
             new() { Id = 0, Name = "Xiaomi", Description="Android", Price=7500, SupplierCompany=Suppliers[0] },
            new() { Id = 1, Name = "Samsung A51", Description="Android", Price=10000, SupplierCompany=Suppliers[0] },

            new() { Id = 2, Name = "Samsung TV", Description="Televizyon", Price=8000,SupplierCompany=Suppliers[0] },
            new() { Id = 3, Name = "Şapka", Description="LCW", Price=300,SupplierCompany=Suppliers[1] },
            new() { Id = 4, Name = "Pantolon", Description="Defacto", Price=800,SupplierCompany=Suppliers[1] },


        };


        }
        public List<Product> GetProducts()
        {
            return products;
        }
    }
}
