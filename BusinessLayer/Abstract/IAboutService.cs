using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAboutService
    {
        List<About> List();
        void Add(About p);
        void Update(About p);
        void Delete(About p);
        About First();
    }
}
