using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiltInInterfaces
{
    public class Product : IComparable<Product>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public double Rating { get; set; }

        public int CompareTo(Product? other)
        {
            if (Rating > other.Rating)
            {
                return 1;
            }
            else if (Rating < other.Rating)
            {
                return -1;
            }

            return 0;
        }
    }

    public class ProductService : IEnumerable<Product>
    {
        private List<Product> products = new List<Product>();
        public ProductService()
        {

        }
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void SortProducts()
        {
            products.Sort();
        }
        public List<Product> GetProducts()
        {
            return products;
        }

        public IEnumerator<Product> GetEnumerator()
        {
            foreach (var item in products)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
