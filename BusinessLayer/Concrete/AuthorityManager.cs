using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AuthorityManager : IAuthorityService
    {
        IAuthorityDal _authorityDal;

        public AuthorityManager(IAuthorityDal authorityDal)
        {
            _authorityDal = authorityDal;
        }

        public void Add(Authority p)
        {
            _authorityDal.Create(p);
        }

        public void Delete(Authority p)
        {
            _authorityDal.Delete(p);
        }

        public Authority Find(int id)
        {
            return _authorityDal.Get(x => x.Id == id);
        }

        public List<Authority> List()
        {
            return _authorityDal.Read();
        }

        public void Update(Authority p)
        {
            _authorityDal.Update(p);
        }
    }
}
