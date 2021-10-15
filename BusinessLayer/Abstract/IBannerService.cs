using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBannerService
    {
        List<Banner> List();
        void Add(Banner p);
        void Update(Banner p);
        void Delete(Banner p);
        Banner First();
    }
}
