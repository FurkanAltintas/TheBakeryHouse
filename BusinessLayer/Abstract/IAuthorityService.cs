using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAuthorityService
    {
        List<Authority> List();
        void Add(Authority p);
        void Update(Authority p);
        void Delete(Authority p);

        Authority Find(int id);
    }
}
