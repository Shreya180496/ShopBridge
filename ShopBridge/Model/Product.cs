using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.Model
{
    public class Product
    {
        [Key]
        public Guid ProductId { get; set; }
        public string prodName { get; set; }
        public string prodDescription { get; set; }
        public decimal prodPrice { get; set; }
        public int prodQuantity { get; set; }

    }
}
