using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdealKarkas.Context.Models
{
    public class Manufacturer
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Hardware> Hardwares { get; set; }
        public override string ToString()
        {
            return $"{Title}";
        }
    }
}
