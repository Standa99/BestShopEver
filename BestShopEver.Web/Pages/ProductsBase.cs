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
        protected IEnumerable<IGrouping<int,ProductDTO>> GetGroupProductsByCategory()
        {
			var groupedProductsByCategory = ProductDTOs.GroupBy(product => product.CategoryId)
							.OrderBy(group => group.Key)
							.Select(g => g);
            return groupedProductsByCategory;
		}

        protected string GetCategoryName(IGrouping<int,ProductDTO> groupedProductDTOs)
        {
            return groupedProductDTOs
                .FirstOrDefault(g => g.CategoryId == groupedProductDTOs.Key)
                .CategoryName;
        }

    }
}
