using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAddressService
    {
        List<Address> List();
        void Add(Address p);
        void Update(Address p);
        void Delete(Address p);
        Address First();
    }
}
