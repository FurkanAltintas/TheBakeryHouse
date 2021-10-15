using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string Map { get; set; }
        public string Home { get; set; }
        public string HomeSubTitle { get; set; }
        public string Phone { get; set; }
        public string PhoneSubTitle { get; set; }
        public string Email { get; set; }
        public string EmailSubTitle { get; set; }
    }
}
