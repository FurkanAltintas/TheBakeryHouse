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
    public class StaffManager : IStaffService
    {
        IStaffDal _staffDal;

        public StaffManager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }

        public void Add(Staff p)
        {
            _staffDal.Create(p);
        }

        public void Delete(Staff p)
        {
            _staffDal.Delete(p);
        }

        public List<Staff> List()
        {
            return _staffDal.Read();
        }

        public void Update(Staff p)
        {
            _staffDal.Update(p);
        }
    }
}
