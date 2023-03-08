﻿using BestShopEver.Api.Entities;
using BestShopEver.Models.DTOs;

namespace BestShopEver.Api.Extensions
{
    public static class DTOConversions
    {
        public static IEnumerable<ProductDTO> ConvertToDTO(this IEnumerable<Product> products,
                                                IEnumerable<ProductCategory> productCategories) 
        {
            return (from  product in products
                    join productCategory in productCategories
                    on product.CategoryId equals productCategory.Id
                    select new ProductDTO
                    {
                        Id = product.Id,
                        Name= product.Name,
                        Description= product.Description,
                        ImageURL = product.ImageUrl,
                        Price = product.Price,
                        Quantity = product.Quantity,
                        CategoryId = product.CategoryId,
                        CategoryName = productCategory.Name
                    }).ToList();
        }

    }
}
