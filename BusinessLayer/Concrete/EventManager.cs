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
    public class EventManager : IEventService
    {
        IEventDal _eventDal;

        public EventManager(IEventDal eventDal)
        {
            _eventDal = eventDal;
        }

        public void Add(Event p)
        {
            _eventDal.Create(p);
        }

        public void Delete(Event p)
        {
            _eventDal.Delete(p);
        }

        public Event Find(int id)
        {
            return _eventDal.Get(x => x.Id == id);
        }

        public List<Event> List()
        {
            return _eventDal.Read();
        }

        public void Update(Event p)
        {
            _eventDal.Update(p);
        }
    }
}
