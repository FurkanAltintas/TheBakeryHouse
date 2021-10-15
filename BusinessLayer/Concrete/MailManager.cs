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
    public class MailManager : IMailService
    {
        IMailDal _mailDal;

        public MailManager(IMailDal mailDal)
        {
            _mailDal = mailDal;
        }

        public void Add(Mail p)
        {
            _mailDal.Create(p);
        }

        public void Delete(Mail p)
        {
            p.IsTrash = true;
            Update(p);
        }

        public Mail Find(int id)
        {
            return _mailDal.Get(x => x.Id == id);
        }

        public List<Mail> Inbox(string mail, string addition = null)
        {
            if (addition == "Starred")
            {
                return _mailDal.Read(x => x.Recipient == mail && x.IsStar == true);
            }

            else if (addition == "Draft")
            {
                return _mailDal.Read(x => x.Recipient == mail && x.IsDraft == true);
            }

            else if (addition == "Trash")
            {
                return _mailDal.Read(x => x.Recipient == mail && x.IsTrash == true);
            }

            return _mailDal.Read(x => x.Recipient == mail);
        }

        public IEnumerable<Mail> SendBox(string p)
        {
            return _mailDal.Read(x => x.Sender == p).OrderByDescending(x => x.History);
        }

        public void Update(Mail p)
        {
            _mailDal.Update(p);
        }
    }
}
