using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMenuService
    {
        List<Menu> List();
        List<Menu> ListTopRated();
        void Add(Menu p);
        void Update(Menu p);
        void Delete(Menu p);

        Menu Find(int id);

        List<Currency> ListCurrency();
    }
}
