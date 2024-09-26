using ManagmentSystem.Core.Interfaces;
using ManagmentSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentSystem.EF.Repositories
{
    public class CategoriesRepository : BaseRepository<Category>, ICategoriesRepository
    {
        private new readonly ApplicationDBContext _context;
        public CategoriesRepository(ApplicationDBContext context) : base(context)
        {
        }
        public IEnumerable<Category> GetAllSpecialMethod()
        {
            throw new NotImplementedException();
        }
    }
}
