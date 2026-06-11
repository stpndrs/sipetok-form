using System;

namespace sipetok_form.Models.dto.request
{
    internal class TenantSaveRequest
    {
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public UserSaveRequest User { get; set; }
    }
}