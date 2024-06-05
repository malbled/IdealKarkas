using IdealKarkas.Context.Enums;
using System.Collections.Generic;

namespace IdealKarkas.Context.Models
{
    public class Staff
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; } = string.Empty;
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Passport { get; set; }
        public string Post { get; set; }
        public TypeUser TypeUser { get; set; }
        public string Login { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public byte[] ImagePreview { get; set; }
        public int? IsActual { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
        public Staff()
        {
            Tasks = new List<Task>();
        }
        public override string ToString()
        {
            return $"{LastName} {FirstName} {Patronymic}";
        }
    }
}
