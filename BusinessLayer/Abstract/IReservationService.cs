using EntityLayer.Concrete;
using EntityLayer.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IReservationService
    {
        List<Reservation> List();
        void Add(Reservation p);
        void Update(Reservation p);
        void Delete(Reservation p);

        Reservation Find(int id);

        List<Calendar> ListCalendar();
    }
}
