using BestShopEver.Models.DTOs;
using Microsoft.AspNetCore.Components;


namespace BestShopEver.Web.Pages
{
	public class DisplayProductsBase:ComponentBase
	{
		[Parameter]
		public IEnumerable<ProductDTO> ProductDTOs { get; set; }
	}
}
