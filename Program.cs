using EFCoreDemo.Database;
using EFCoreDemo.Models;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using WebshopContext db = new WebshopContext();

            User zvone = new User()
            {
                Name = "Zvonimir Matic",
                Email = "zvonimir@incubis.hr",
                Addresses = new List<Address>()
                {
                    new Address()
                    {
                        Country = "Croatia",
                        City = "Rijeka",
                        PostalCode = "51000",
                        StreetName = "Petra Jurcica",
                        StreetNumber = "16"
                    }
                }
            };

            User john = new User()
            {
                Name = "John Smith",
                Email = "john@mail.com"
            };

            db.Users.Add(zvone);
            db.Users.Add(john);
            db.SaveChanges();

            IEnumerable<User> queryUsers = db.Users.Where(x => x.Name.ToLower().Contains("john"));

            foreach (User user in queryUsers)
            {
                user.Name = "Zvonimir Matic";
            }
            db.SaveChanges();
        }
    }
}
