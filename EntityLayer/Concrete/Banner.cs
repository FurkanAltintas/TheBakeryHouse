using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Banner
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Url { get; set; }
        public string Button { get; set; }
    }
}
