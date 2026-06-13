using sipetok_api.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace sipetok_form.Models
{
    internal class Operational
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string OperationalCost { get; set; } = string.Empty;

        public int TenantId { get; set; }

        public virtual Tenant? Tenant { get; set; }
        public DateTime OperationalDate { get; set; }

        public Operational() { }

        public Operational(int Id, string Name, string OperationalCost, int TenantId, DateTime OperationalDate)
        {
            this.Id = Id;
            this.Name = Name;
            this.OperationalCost = OperationalCost;
            this.TenantId = TenantId;
            this.OperationalDate = OperationalDate;
        }
    }
}
