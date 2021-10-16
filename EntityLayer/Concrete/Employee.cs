using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Employee
    {
        public int Id { get; set; }
        public int AuthorityId { get; set; }
        [ForeignKey("AuthorityId")]
        public virtual Authority Authority { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string UserName { get; set; }
        public virtual string FullName { get => Name + " " + SurName; }
        public string Profile { get; set; }
        public string Mobile { get; set; }
        public string About { get; set; }
        public string WebSite { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RPassword { get; set; }
    }
}
