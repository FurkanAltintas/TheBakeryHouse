using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private Context c = new Context();
        private readonly DbSet<T> _object;

        public GenericRepository()
        {
            _object = c.Set<T>();
        }
        public void Create(T p)
        {
            c.Entry(p).State = EntityState.Added;
            c.SaveChanges();
        }

        public void Delete(T p)
        {
            c.Entry(p).State = EntityState.Deleted;
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }

        public List<T> Read(Expression<Func<T, bool>> filter = null)
        {
            if (filter != null)
            {
                return _object.Where(filter).ToList();
            }
            else
            {
                return _object.ToList();
            }
        }

        public void Update(T p)
        {
            c.Entry(p).State = EntityState.Modified;
            c.SaveChanges();
        }
    }
}
