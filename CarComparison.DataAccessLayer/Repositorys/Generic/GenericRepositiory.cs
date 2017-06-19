using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarComparison.DataAccessLayer.Context;
using System.Data.Entity;

namespace CarComparison.DataAccessLayer.Repositorys.Generic
{
    public abstract class GenericRepositiory<T> : IRepository<T> where T : class
    {
        private readonly CarContext _context;

        private readonly DbSet<T> _dbSet;

        public GenericRepositiory(CarContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Update(T enity)
        {
            _dbSet.Attach(enity);
            _context.Entry(enity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
