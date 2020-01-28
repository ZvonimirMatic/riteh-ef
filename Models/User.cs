using System.Collections.Generic;

namespace EFCoreDemo.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public List<Address> Addresses { get; set; }
        public List<Order> Orders { get; set; }
    }
}
