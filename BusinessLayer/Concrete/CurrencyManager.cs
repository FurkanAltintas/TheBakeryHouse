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
    public class CurrencyManager : ICurrencyService
    {
        ICurrencyDal _currencyDal;

        public CurrencyManager(ICurrencyDal currencyDal)
        {
            _currencyDal = currencyDal;
        }

        public void Add(Currency p)
        {
            _currencyDal.Create(p);
        }

        public void Delete(Currency p)
        {
            _currencyDal.Delete(p);
        }

        public Currency Find(int id)
        {
            return _currencyDal.Get(x => x.Id == id);
        }

        public List<Currency> List()
        {
            return _currencyDal.Read();
        }

        public void Update(Currency p)
        {
            _currencyDal.Update(p);
        }
    }
}
