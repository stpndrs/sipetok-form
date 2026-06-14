using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace sipetok_form.Models
{
    internal class Egg
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public DateTime ProductionDate { get; set; }
        public double Stock { get; set; }
    }
}
