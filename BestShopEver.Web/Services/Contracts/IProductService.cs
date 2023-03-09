using BestShopEver.Models.DTOs;

namespace BestShopEver.Web.Services.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetItems();
    }
}
