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
    public class GalleryManager : IGalleryService
    {
        IGalleryDal _galleryDal;

        public GalleryManager(IGalleryDal galleryDal)
        {
            _galleryDal = galleryDal;
        }

        public void Add(Gallery p)
        {
            _galleryDal.Create(p);
        }

        public void Delete(Gallery p)
        {
            _galleryDal.Delete(p);
        }

        public List<Gallery> List()
        {
            return _galleryDal.Read();
        }

        public void Update(Gallery p)
        {
            _galleryDal.Update(p);
        }
    }
}
