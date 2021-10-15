using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICurrencyService
    {
        List<Currency> List();
        void Add(Currency p);
        void Update(Currency p);
        void Delete(Currency p);
    }
}
