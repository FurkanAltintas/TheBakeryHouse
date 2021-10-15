using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGalleryService
    {
        List<Gallery> List();
        void Add(Gallery p);
        void Update(Gallery p);
        void Delete(Gallery p);
    }
}
