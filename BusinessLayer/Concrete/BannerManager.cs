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
    public class BannerManager : IBannerService
    {
        IBannerDal _bannerDal;

        public BannerManager(IBannerDal bannerDal)
        {
            _bannerDal = bannerDal;
        }

        public void Add(Banner p)
        {
            _bannerDal.Create(p);
        }

        public void Delete(Banner p)
        {
            _bannerDal.Delete(p);
        }

        public Banner First()
        {
            return _bannerDal.First();
        }

        public List<Banner> List()
        {
            return _bannerDal.Read();
        }

        public void Update(Banner p)
        {
            _bannerDal.Update(p);
        }
    }
}
