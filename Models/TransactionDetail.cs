using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace sipetok_form.Models
{
    internal class TransactionDetail
    {

        public int Id { get; set; }

        public int TransactionId { get; set; }

        public virtual Transaction? Transaction { get; set; }

        public int CategoryId { get; set; }

        public virtual EggCategory? Category { get; set; }
        public double Quantity { get; set; }
        public decimal PriceAtPurchase { get; set; }
        public decimal Subtotal { get; set; }

        public TransactionDetail() { }

        public TransactionDetail(int Id, int TransactionId, int CategoryId, double Quantity, decimal PriceAtPurchase, decimal Subtotal)
        {
            this.Id = Id;
            this.TransactionId = TransactionId;
            this.CategoryId = CategoryId;
            this.Quantity = Quantity;
            this.PriceAtPurchase = PriceAtPurchase;
            this.Subtotal = Subtotal;
        }
    }
}
