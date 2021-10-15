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
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public void Add(Employee p)
        {
            _employeeDal.Create(p);
        }

        public void Delete(Employee p)
        {
            _employeeDal.Delete(p);
        }

        public Employee Find(string email)
        {
            return _employeeDal.Get(x => x.Email == email);
        }

        public List<Employee> List()
        {
            return _employeeDal.Read();
        }

        public bool Login(Employee p)
        {
            var login = _employeeDal.Get(x => x.Email == p.Email && x.Password == p.Password);

            if (login != null)
            {
                return true;
            }

            return false;
        }

        public void Update(Employee p)
        {
            _employeeDal.Update(p);
        }
    }
}
