using System;

namespace sipetok_form.Dto.request
{
    internal class TenantSaveRequest
    {
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public bool IsValid { get; set; }
        public UserSaveRequest User { get; set; }
    }
}