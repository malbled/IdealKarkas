using System.Collections.Generic;

namespace IdealKarkas.Context.Models
{
    public class ObjectMod
    {
        public int Id { get; set; }
        public int TypeObjectId { get; set; }
        public virtual TypeObject TypeObject { get; set; }
        public string Title { get; set; }
        public decimal Area { get; set; }
        public int Floor { get; set; }
        public int CountBedroom { get; set; }
        public int CountBathroom { get; set; }
        public int MinPeriod { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public byte[] ImagePreview { get; set; }
        public int? IsActual { get; set; }
        public virtual ICollection<ObjectOrder> ObjectOrders { get; set; }
    }
}
