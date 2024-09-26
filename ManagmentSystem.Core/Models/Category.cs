using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentSystem.Core.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string AName { get; set; }
        public string EName { get; set; }
        public string Description { get; set; }
        public DateTime LastAccessed { get; set; }
        public ICollection<CategoryProduct> CategoryProducts { get; set; }
    }
}
