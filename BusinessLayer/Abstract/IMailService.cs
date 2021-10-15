using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMailService
    {
        List<Mail> Inbox(string p=null, string addition = null);
        IEnumerable<Mail> SendBox(string mail);

        void Add(Mail p);
        void Update(Mail p);
        void Delete(Mail p);

        Mail Find(int id);
    }
}
