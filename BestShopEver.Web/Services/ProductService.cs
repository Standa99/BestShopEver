using BestShopEver.Models.DTOs;
using BestShopEver.Web.Services.Contracts;
using System.Net.Http.Json;

namespace BestShopEver.Web.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<ProductDTO>> GetItems()
        {
            try 
            {
                var products = await _httpClient.GetFromJsonAsync<IEnumerable<ProductDTO>>("api/Product");
                return products;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
