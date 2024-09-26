using ManagmentSystem.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentSystem.Core.UnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        //IBaseRepository<Category> Categories { get; } After add spicial method
        ICategoriesRepository Categories { get; } // After add spicial method
        int Complete();
    }
}
