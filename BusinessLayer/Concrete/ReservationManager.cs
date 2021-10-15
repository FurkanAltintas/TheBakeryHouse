using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ReservationManager : IReservationService
    {
        IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public void Add(Reservation p)
        {
            _reservationDal.Create(p);
        }

        public List<Calendar> ListCalendar()
        {
            List<Calendar> calendars = new List<Calendar>();

            var list = _reservationDal.Read();
            foreach (var item in list)
            {
                calendars.Add(new Calendar()
                {
                    //'2018-03-13T07:00:00'
                    title = item.Message,
                    start = item.StartDate,
                    end = item.EndDate
                });
            }
            return calendars;
        }

        public void Delete(Reservation p)
        {
            _reservationDal.Delete(p);
        }

        public Reservation Find(int id)
        {
            return _reservationDal.Get(x => x.Id == id);
        }

        public List<Reservation> List()
        {
            return _reservationDal.Read();
        }

        public void Update(Reservation p)
        {
            _reservationDal.Update(p);
        }
    }
}
