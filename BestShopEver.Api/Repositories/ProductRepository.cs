using BestShopEver.Api.Data;
using BestShopEver.Api.Entities;
using BestShopEver.Api.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace BestShopEver.Api.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly BestShopEverDbContext _context;
        public ProductRepository(BestShopEverDbContext bestShopEverDbContext)
        {
            _context = bestShopEverDbContext;
        }

        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            var categories = await _context.ProductCategories.ToListAsync();
            return categories;
        }

        public Task<ProductCategory> GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await _context.Products.ToListAsync();
            return products;

        }
    }
}
