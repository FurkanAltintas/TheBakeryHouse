using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IEmployeeService
    {
        List<Employee> List();
        void Add(Employee p);
        void Update(Employee p);
        void Delete(Employee p);

        Employee Find(string email);
        bool Login(Employee p);
    }
}
