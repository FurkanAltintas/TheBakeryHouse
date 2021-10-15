using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T> where T : class
    {
        //CRUD --> Create - Read - Update -Delete
        void Create(T p);
        List<T> Read(Expression<Func<T, bool>> filter = null);
        void Update(T p);
        void Delete(T p);
        T Get(Expression<Func<T, bool>> filter);
    }
}
