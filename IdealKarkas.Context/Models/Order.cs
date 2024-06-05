using System;
using System.Collections.Generic;

namespace IdealKarkas.Context.Models
{
    public class Order
    {
        public int Id { get; set; } 
        public string NumberProject { get; set; }
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        public int StaffId { get; set; }
        public virtual Staff Staff { get; set; }
        public DateTimeOffset DateAdd { get; set; }
        public DateTimeOffset DateEnd { get; set; }
        public DateTimeOffset? DateEndFact { get; set; }
        public DateTimeOffset? DatePayFact { get; set; }
        public string Address { get; set; }
        public decimal AllPrice { get; set; }
        public string Description { get; set; }
        public virtual ICollection<ObjectOrder> ObjectOrders { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }

        public Order()
        {
            Tasks = new List<Task>();
        }
    }
}
