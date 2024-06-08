using IdealKarkas.Context.Models;
using System.Data.Entity;

namespace IdealKarkas.Context
{
    public class IKContext : DbContext
    {
        public IKContext() : base ("DefaultConnection") { }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Hardware> Hardwares { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<ObjectMod> ObjectMods { get; set; }
        public DbSet<TypeObject> TypeObjects { get; set; }
        public DbSet <ObjectOrder> ObjectOrders { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
    }
}
