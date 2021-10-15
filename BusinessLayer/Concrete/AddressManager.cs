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
    public class AddressManager : IAddressService
    {
        IAddressDal _addressDal;

        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }

        public void Add(Address p)
        {
            _addressDal.Create(p);
        }

        public void Delete(Address p)
        {
            _addressDal.Delete(p);
        }

        public Address First()
        {
            return _addressDal.First();
        }

        public List<Address> List()
        {
            return _addressDal.Read();
        }

        public void Update(Address p)
        {
            _addressDal.Update(p);
        }
    }
}
