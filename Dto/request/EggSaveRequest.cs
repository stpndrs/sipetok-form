using System;

namespace sipetok_form.Dto.request
{
    internal class EggSaveRequest
    {
        public DateTime ProductionDate { get; set; }
        public double Stock { get; set; }
        public int CategoryId { get; set; }
    }
}