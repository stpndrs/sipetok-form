using System;

namespace sipetok_form.Models.dto.request
{
    internal class OperationalSaveRequest
    {
        public string Name { get; set; } = string.Empty;
        public string OperationalCost { get; set; } = string.Empty;
        public int TenantId { get; set; }
        public DateTime OperationalDate { get; set; }
    }
}