using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdealKarkas.Context.Models
{
    public class ObjectOrder
    {
        public int Id { get; set; }
        public int ObjectModId { get; set; }
        public virtual ObjectMod ObjectMod { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        public int CountObject { get; set; }

    }
}
