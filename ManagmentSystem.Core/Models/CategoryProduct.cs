using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentSystem.Core.Models
{
    public class CategoryProduct
    {
        public DateTime LastAccessed { get; set; }
        public int? CategoryId { get; set; }
        public Category Category { get; set; }

        public int? ProductId { get; set; }
        public Product Product { get; set; }
    }
}
