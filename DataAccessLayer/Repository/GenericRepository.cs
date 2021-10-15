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
        public void Create(T p)
        {
            using (var db = new Context())
            {
                db.Entry(p).State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Delete(T p)
        {
            using (var db = new Context())
            {
                db.Entry(p).State = EntityState.Deleted;
            }
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            using (var db = new Context())
            {
                return db.Set<T>().SingleOrDefault(filter);
            }
        }

        public List<T> Read(Expression<Func<T, bool>> filter = null)
        {
            using (var db = new Context())
            {
                if (filter != null)
                {
                    return db.Set<T>().Where(filter).ToList();
                }
                else
                {
                    return db.Set<T>().ToList();
                }
            }
        }

        public void Update(T p)
        {
            using (var db = new Context())
            {
                db.Entry(p).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
