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
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void Add(Contact p)
        {
            _contactDal.Create(p);
        }

        public void Delete(Contact p)
        {
            _contactDal.Delete(p);
        }

        public Contact Find(int id)
        {
            return _contactDal.Get(x => x.Id == id);
        }

        public List<Contact> List()
        {
            return _contactDal.Read();
        }

        public void Update(Contact p)
        {
            _contactDal.Update(p);
        }
    }
}
