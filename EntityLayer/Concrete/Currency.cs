using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Currency
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public ICollection<Menu> Menu { get; set; }
    }
}
