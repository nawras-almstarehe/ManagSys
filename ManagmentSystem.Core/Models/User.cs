using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentSystem.Core.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool isAdmin { get; set; }
        public bool isSeller { get; set; }
        public DateTime LastAccessed { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
