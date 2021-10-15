using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContactService
    {
        List<Contact> List();
        void Add(Contact p);
        void Update(Contact p);
        void Delete(Contact p);

        Contact Find(int id);
    }
}
