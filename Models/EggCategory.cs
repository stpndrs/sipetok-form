using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace sipetok_form.Models
{
    internal class EggCategory
    {
        public int Id { get; set; }

        // Gunakan decimal untuk harga
        public decimal Price { get; set; }

        public string Description { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public int TenantId { get; set; }

        public virtual Tenant? Tenant { get; set; }

        public virtual ICollection<Egg> Eggs { get; set; } = new List<Egg>();

        public EggCategory() { }

        public EggCategory(int Id, decimal Price, string Description, string Name)
        {
            this.Id = Id;
            this.Price = Price;
            this.Description = Description;
            this.Name = Name;
        }
    }
}
