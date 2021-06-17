using System;
using System.Collections.Generic;

#nullable disable

namespace Choudhary.DAL.Models
{
    public partial class Order
    {
        public long PurchaseId { get; set; }
        public string EmailId { get; set; }
        public string ProductId { get; set; }
        public short QuantityPurchased { get; set; }
        public DateTime DateOfPurchase { get; set; }

        public virtual Customer Email { get; set; }
        public virtual Product Product { get; set; }
    }
}
