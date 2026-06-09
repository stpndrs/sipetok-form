using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace sipetok_form.Models
{
    internal class Egg
    {
        public int Id { get; set; }
        public DateTime ProductionDate { get; set; }
        public double Stock { get; set; }

        public int CategoryId { get; set; }

        public virtual EggCategory? Category { get; set; }

        public Egg() { }

        public Egg(int Id, DateTime ProductionDate, double Stock, int CategoryId)
        {
            this.Id = Id;
            this.ProductionDate = ProductionDate;
            this.Stock = Stock;
            this.CategoryId = CategoryId;
        }
    }
}
