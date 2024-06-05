using IdealKarkas.Context.Enums;
using System.Collections.Generic;

namespace IdealKarkas.Context.Models
{
    public class Hardware
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SerialNumber { get; set; }
        public string Manufacturer { get; set; }
        public string Description { get; set; } = string.Empty;
        public int? IsActual { get; set; }
        public TypeOvership TypeOvership { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
        public override string ToString()
        {
            return $"{SerialNumber}";
        }
        public Hardware()
        {
            Tasks = new List<Task>();
        }
    }
}
