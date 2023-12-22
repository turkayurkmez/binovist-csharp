using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMechanism
{
    public class Product
    {
        public string Name { get; set; }
    }

    public class ProductCreatedEventArgs
    {
        public Product Product { get; set; }
        public string User { get; set; }
        public DateTime CreatedDate { get; set; }
    }


    public class ProductService
    {

        public delegate void ProductCreatedEventHandler(object sender, ProductCreatedEventArgs e);
        public event ProductCreatedEventHandler ProductCreated;

        public void CreateProduct(Product product)
        {
            //varsayın ki db'ye eklendi.
            var args = new ProductCreatedEventArgs { CreatedDate = DateTime.Now, Product = product, User = "türkay" };
            OnProductCreated(args);

        }

        public void OnProductCreated(ProductCreatedEventArgs e)
        {
            if (ProductCreated != null)
            {
                ProductCreated(this, e);
            }
        }
    }
}
