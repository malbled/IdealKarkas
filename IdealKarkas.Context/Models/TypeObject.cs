using System.Collections.Generic;

namespace IdealKarkas.Context.Models
{
    public class TypeObject
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual ICollection<ObjectMod> ObjectMods { get; set; }
    }
}
