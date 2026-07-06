using System;

namespace sipetok_form.Dto.request
{
    internal class EggCategorySaveRequest
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int TenantId { get; set; }
    }
}