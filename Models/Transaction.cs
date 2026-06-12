using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace sipetok_form.Models
{
    internal class Transaction
    {
        public DateTime Date { get; set; }
        public decimal PaymentAmount { get; set; }
        public decimal TotalPrice { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerPhoneNumber { get; set; } = string.Empty;
        public virtual ICollection<TransactionDetail> Details { get; set; } = new List<TransactionDetail>();
        public int TenantId { get; set; }
    }

    internal class TransactionDetail
    {
        public int CategoryId { get; set; }
        public double Quantity { get; set; }
        public decimal PriceAtPurchase { get; set; }
        public decimal Subtotal { get; set; }
    }
}
