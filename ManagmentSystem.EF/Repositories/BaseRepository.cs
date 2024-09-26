using ManagmentSystem.Core.Interfaces;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentSystem.EF.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected ApplicationDBContext _context;

        public BaseRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<T> Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            //_context.SaveChanges(); For added UnitOfWork
            return entity;
        }

        public async Task<T> Update(T entity)
        {
             _context.Set<T>().Update(entity);
            return entity;
        }

        public void Delete(int id)
        {
            if (id != 0)
            {
                var entity = GetById(id);
                _context.Remove(entity);
            }
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }


        //public IEnumerable<T> AddRange(IEnumerable<T> entities)
        //{
        //    _context.Set<T>().AddRange(entities);
        //    //_context.SaveChanges(); For added UnitOfWork
        //    return entities;
        //}

        //public void Attach(T entity)
        //{
        //    _context.Set<T>().Attach(entity);
        //}

        //public int Count()
        //{
        //    return _context.Set<T>().Count();
        //}

        //public int Count(Expression<Func<T, bool>> match)
        //{
        //    return _context.Set<T>().Count(match);
        //}

        //public void Delete(T entity)
        //{
        //    _context.Set<T>().Remove(entity);
        //}

        //public void DeleteRange(IEnumerable<T> entities)
        //{
        //    _context.Set<T>().RemoveRange(entities);
        //}

        //public T Find(Expression<Func<T, bool>> match)
        //{
        //    return _context.Set<T>().SingleOrDefault(match);
        //}

        //public IEnumerable<T> FindAll(Expression<Func<T, bool>> match, string[] includes = null)
        //{
        //    IQueryable<T> query = _context.Set<T>();
        //    if (includes != null)
        //    {
        //        foreach (var include in includes)
        //        {
        //            query = query.Include(include);
        //        }
        //    }

        //    return query.Where(match).ToList();
        //}

        //public IEnumerable<T> FindAll(Expression<Func<T, bool>> match, int take, int skip)
        //{
        //    return _context.Set<T>().Where(match).Skip(skip).Take(take).ToList();
        //}

        //public IEnumerable<T> FindAll(Expression<Func<T, bool>> match, int? take, int? skip, Expression<Func<T, object>> orderBy = null, string orderByDirection = "ASC")
        //{
        //    IQueryable<T> query = _context.Set<T>().Where(match);
        //    if (take.HasValue)
        //    {
        //        query = query.Take(take.Value);
        //    }
        //    if (skip.HasValue)
        //    {
        //        query = query.Skip(skip.Value);
        //    }
        //    if (orderBy != null)
        //    {
        //        if (orderByDirection == Const.cnstAscending)
        //        {
        //            query = query.OrderBy(orderBy);
        //        }
        //        else
        //        {
        //            query = query.OrderByDescending(orderBy);
        //        }
        //    }

        //    return query.ToList();
        //}

        //public T FindByAnyData(Expression<Func<T, bool>> match, string[] includes = null)
        //{
        //    IQueryable<T> query = _context.Set<T>();
        //    if (includes != null)
        //    {
        //        foreach (var include in includes)
        //        {
        //            query = query.Include(include);
        //        }
        //    }

        //    return query.SingleOrDefault(match);
        //}

        //public T GetById(int id)
        //{
        //    return _context.Set<T>().Find(id);
        //} 
    }
}
