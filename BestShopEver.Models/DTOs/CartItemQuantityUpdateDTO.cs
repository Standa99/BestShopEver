using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestShopEver.Models.DTOs
{
    public class CartItemQuantityUpdateDTO
    {
        public int CartItemId { get; set; }
        public int Quantity { get; set; }
    }
}
