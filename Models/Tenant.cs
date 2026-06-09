using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace sipetok_form.Models
{
    internal class Tenant
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public bool IsValid { get; set; }

        public int UserId { get; set; }

        public virtual User? User { get; set; }

        public Tenant() { }

        public Tenant(int Id, string Name, string Address, string PhoneNumber, int UserId)
        {
            this.Id = Id;
            this.Name = Name;
            this.Address = Address;
            this.PhoneNumber = PhoneNumber;
            this.UserId = UserId;
        }
    }
}
