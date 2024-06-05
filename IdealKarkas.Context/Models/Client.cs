using IdealKarkas.Context.Enums;
using System;
using System.Collections.Generic;

namespace IdealKarkas.Context.Models
{
    public class Client
    {
        public int Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; } = string.Empty;  
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string CompanyName { get; set; } = string.Empty;
        public string INN { get; set; } = string.Empty;
        public string CityCompany { get; set; } = string.Empty;
        public DateTimeOffset DateRegistration { get; set; }
        public TypeClient TypeClient { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public override string ToString()
        {
            return $"{LastName} {FirstName} {Patronymic}";
        }
    }
}
