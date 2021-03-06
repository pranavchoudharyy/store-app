using System;
using System.Collections.Generic;

namespace Choudhary.DAL.Models
{
    public partial class Customers
    {
        public Customers()
        {
            Orders = new HashSet<Orders>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string SecondaryEmailId { get; set; }
        public string CustomerPassword { get; set; }
        public decimal Phone { get; set; }
        public decimal? SecondaryPhone { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
