using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace sipetok_form.Models
{
    internal class Operational
    {
        public string Name { get; set; } = string.Empty;
        public string OperationalCost { get; set; } = string.Empty;
        public int TenantId { get; set; }
    }
}
