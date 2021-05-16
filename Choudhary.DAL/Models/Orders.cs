using System;
using System.Collections.Generic;

namespace Choudhary.DAL.Models
{
    public partial class Orders
    {
        public long PurchaseId { get; set; }
        public string EmailId { get; set; }
        public string ProductId { get; set; }
        public short QuantityPurchased { get; set; }
        public DateTime DateOfPurchase { get; set; }

        public virtual Customers Email { get; set; }
        public virtual Products Product { get; set; }
    }
}
