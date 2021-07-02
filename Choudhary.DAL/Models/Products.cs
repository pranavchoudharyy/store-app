using System;
using System.Collections.Generic;

namespace Choudhary.DAL.Models
{
    public partial class Products
    {
        public Products()
        {
            Orders = new HashSet<Orders>();
        }

        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public int? CategoryId { get; set; }
        public decimal Price { get; set; }
        public int QuantityAvailable { get; set; }

        public virtual Categories Category { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
