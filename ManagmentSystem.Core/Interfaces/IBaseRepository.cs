using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentSystem.Core.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        //T GetById(int id);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetByIdAsync(int id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        void Delete(int id);
        T GetById(int id);

        //T Find(Expression<Func<T, bool>> match);
        //T FindByAnyData(Expression<Func<T, bool>> match, string[] includes = null);
        //IEnumerable<T> FindAll(Expression<Func<T, bool>> match, string[] includes = null);
        //IEnumerable<T> FindAll(Expression<Func<T, bool>> match, int take, int skip);
        //IEnumerable<T> FindAll(Expression<Func<T, bool>> match, int? take, int? skip, 
        //    Expression<Func<T, object>> orderBy = null, string orderByDirection = Const.cnstAscending);
        //IEnumerable<T> AddRange(IEnumerable<T> entities);
        //void DeleteRange(IEnumerable<T> entities);
        //void Attach(T entity);
        //int Count();
        //int Count(Expression<Func<T, bool>> match);
    }
}
