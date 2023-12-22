using eshop.Application.DataTransferObjects.Requests;
using eshop.Domains.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.Application
{
    public interface IProductService
    {
        Task<int> CreateProduct(CreateProductRequest request);
        Task<Product> GetProductByIdAsync(int id);
        IEnumerable<Product> GetProducts();
        Task<IEnumerable<Product>> GetProductsByName(string name);
        Task UpdateProduct(UpdateProductRequest request);
    }
}
