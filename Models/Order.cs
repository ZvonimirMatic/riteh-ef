using System;
using System.Collections.Generic;

namespace EFCoreDemo.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime TimeOrdered { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int AddressId { get; set; }
        public Address Address { get; set; }

        public List<OrderProduct> OrderProducts { get; set; }
    }
}
