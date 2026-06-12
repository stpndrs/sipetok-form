using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace sipetok_form.Models
{
    internal class EggCategory
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int TenantId { get; set; }
    }
}
