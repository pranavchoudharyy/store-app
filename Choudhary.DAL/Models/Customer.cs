using System;
using System.Collections.Generic;

#nullable disable

namespace Choudhary.DAL.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public string Name { get; set; }
        public string EmailId { get; set; }
        public string CustomerPassword { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public decimal? Phone { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
