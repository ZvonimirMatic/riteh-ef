using System.Collections.Generic;

namespace EFCoreDemo.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public List<Order> Orders { get; set; }
    }
}
