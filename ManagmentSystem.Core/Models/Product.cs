using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentSystem.Core.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public double Quantity { get; set; }
        public bool Status { get; set; }
        public int? UserId { get; set; }
        public DateTime LastAccessed { get; set; }
        public User User { get; set; }
        public ICollection<CategoryProduct> CategoryProducts { get; set; }
        public ICollection<Transaction> Transactions { get; set; }

    }
}
