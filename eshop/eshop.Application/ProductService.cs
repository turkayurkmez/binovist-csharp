using eshop.Application.DataTransferObjects.Requests;
using eshop.Domains.Entities;
using shop.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.Application
{
    public class ProductService : IProductService
    {

        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<int> CreateProduct(CreateProductRequest request)
        {
            var product = new Product
            {
                Name = request.Name,
                CategoryId = request.CategoryId,
                Description = request.Description,
                ImageUrl = request.ImageUrl,
                Price = request.Price

            };
            await productRepository.CreateAsync(product);
            return product.Id;
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await productRepository.GetByIdAsync(id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return productRepository.Get();
        }

        public async Task<IEnumerable<Product>> GetProductsByName(string name)
        {
            return await productRepository.SearchByNameAsync(name);
        }

        public async Task UpdateProduct(UpdateProductRequest request)
        {
            var product = new Product()
            {
                CategoryId = request.CategoryId,
                Name = request.Name,
                Id = request.Id,
                Description = request.Description,
                ImageUrl = request.ImageUrl,
                Price = request.Price
            };

            await productRepository.UpdateAsync(product);
        }
    }
}
