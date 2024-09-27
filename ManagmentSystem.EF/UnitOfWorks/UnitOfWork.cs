using ManagmentSystem.Core.Interfaces;
using ManagmentSystem.Core.UnitOfWorks;
using ManagmentSystem.EF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentSystem.EF.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDBContext _context;
        public UnitOfWork(ApplicationDBContext context)
        {
            _context = context;
            //Categories = new BaseRepository<Category>(_context);//initial // Comment after add spicial method
            Categories = new CategoriesRepository(_context);// After add spicial method
        }

        //public IBaseRepository<Category> Categories { get; private set; } After add spicial method
        public ICategoriesRepository Categories { get; private set; } // After add spicial method

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
        //ddd
    }
}
