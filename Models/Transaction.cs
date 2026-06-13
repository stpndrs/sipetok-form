using sipetok_api.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace sipetok_form.Models
{
    internal class Transaction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal PaymentAmount { get; set; }
        public decimal TotalPrice { get; set; }
        public string PaymentStatus { get; set; } = string.Empty;
        public string OrderStatus { get; set; } = string.Empty;
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerPhoneNumber { get; set; } = string.Empty;
        public virtual ICollection<TransactionDetail> Details { get; set; } = new List<TransactionDetail>();
        [Browsable(false)]
        public int TenantId { get; set; }

    internal class TransactionDetail
    {
        public int CategoryId { get; set; }
        public EggCategory Category { get; set; }
        public double Quantity { get; set; }
        public decimal PriceAtPurchase { get; set; }
        public decimal Subtotal { get; set; }
        public virtual Tenant? Tenant { get; set; }
    }
}
