using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestShopEver.Models.DTOs
{
    public class CartItemToAddDTO
    {
        public int CartId { get; set; }
        public string ProductId { get; set; }
        public string Quantity { get; set; }
    }
}
