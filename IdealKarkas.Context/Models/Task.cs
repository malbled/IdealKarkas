using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdealKarkas.Context.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTimeOffset DateAdd { get; set; }
        public string AdminFIO { get; set; }

        public virtual ICollection<Hardware> Hardwares { get; set; }
        public virtual ICollection<Staff> Staffs { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public override string ToString()
        {
            return $"{Title}";
        }
        public Task()
        {
            Hardwares = new List<Hardware>();
            Staffs = new List<Staff>();
            Orders = new List<Order>();
        }
        
    }
}
