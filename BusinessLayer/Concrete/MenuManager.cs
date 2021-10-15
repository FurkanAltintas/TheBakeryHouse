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
    public class MenuManager : IMenuService
    {
        IMenuDal _menuDal;
        ICurrencyDal _currencyDal;

        public MenuManager(IMenuDal menuDal, ICurrencyDal currencyDal=null)
        {
            _menuDal = menuDal;
            _currencyDal = currencyDal;
        }

    public void Add(Menu p)
    {
        _menuDal.Create(p);
    }

    public void Delete(Menu p)
    {
        _menuDal.Delete(p);
    }

    public Menu Find(int id)
    {
        return _menuDal.Get(x => x.Id == id);
    }

    public List<Menu> List()
    {
        return _menuDal.Read();
    }

        public List<Currency> ListCurrency()
        {
            return _currencyDal.Read();
        }

        public List<Menu> ListTopRated()
    {
        return _menuDal.Read(x => x.IsTopRated == true);
    }

    public void Update(Menu p)
    {
        _menuDal.Update(p);
    }
}
}
