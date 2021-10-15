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
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void Add(About p)
        {
            _aboutDal.Create(p);
        }

        public void Delete(About p)
        {
            _aboutDal.Delete(p);
        }

        public About First()
        {
            return _aboutDal.First();
        }

        public List<About> List()
        {
            return _aboutDal.Read();
        }

        public void Update(About p)
        {
            _aboutDal.Update(p);
        }
    }
}
