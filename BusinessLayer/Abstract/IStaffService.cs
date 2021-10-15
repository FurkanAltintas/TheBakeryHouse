using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IStaffService
    {
        List<Staff> List();
        void Add(Staff p);
        void Update(Staff p);
        void Delete(Staff p);
    }
}
