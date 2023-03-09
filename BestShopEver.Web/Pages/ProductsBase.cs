using BestShopEver.Models.DTOs;
using BestShopEver.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace BestShopEver.Web.Pages
{
    public class ProductsBase : ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }

        public IEnumerable<ProductDTO> ProductDTOs { get; set; }

        protected override async Task OnInitializedAsync()
        {
            ProductDTOs = await ProductService.GetItems();
        }
    }
}
