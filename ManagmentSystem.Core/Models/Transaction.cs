using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentSystem.Core.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public double Quantity { get; set; }
        public DateTime LastAccessed { get; set; }
        public int? UserId { get; set; }
        public int? ProductId { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }

    }
}
