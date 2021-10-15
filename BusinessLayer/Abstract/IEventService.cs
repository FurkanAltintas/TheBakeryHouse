using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IEventService
    {
        List<Event> List();
        void Add(Event p);
        void Update(Event p);
        void Delete(Event p);

        Event Find(int id);
    }
}
