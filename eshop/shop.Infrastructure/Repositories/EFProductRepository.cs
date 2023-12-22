using eshop.Domains.Entities;
using Microsoft.EntityFrameworkCore;
using shop.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Infrastructure.Repositories
{
    public class EFProductRepository : IProductRepository
    {

        private readonly EshopDbContext eshopDbContext;

        public EFProductRepository(EshopDbContext eshopDbContext)
        {
            this.eshopDbContext = eshopDbContext;
        }

        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public async Task CreateAsync(Product entity)
        {
            await eshopDbContext.Products.AddAsync(entity);

            await eshopDbContext.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> Get()
        {
            return eshopDbContext.Products.ToList();
        }

        public Task<IEnumerable<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await eshopDbContext.Products.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Product>> SearchByNameAsync(string name)
        {
            return await eshopDbContext.Products.Where(p => p.Name.Contains(name)).ToListAsync();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Product entity)
        {
            eshopDbContext.Products.Update(entity);
            await eshopDbContext.SaveChangesAsync();
        }
    }
}
