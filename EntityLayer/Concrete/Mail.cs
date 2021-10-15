using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Mail
    {
        public int Id { get; set; }
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string Attachments { get; set; }
        public bool IsDraft { get; set; } //draft
        public bool IsStar { get; set; } //star
        public bool IsRead { get; set; } //read
        public bool IsTrash { get; set; } //trash
        public DateTime History { get; set; }
    }
}
