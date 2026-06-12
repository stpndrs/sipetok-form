using System;

namespace sipetok_form.Models.dto.request
{
    internal class TransactionSaveRequest
    {
        public DateTime Date { get; set; }
        public decimal PaymentAmount { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerPhoneNumber { get; set; } = string.Empty;
        public virtual ICollection<TransactionDetailSaveRequest> Details { get; set; } = new List<TransactionDetailSaveRequest>();
        public int TenantId { get; set; }
    }

    internal class TransactionDetailSaveRequest
    {
        public int CategoryId { get; set; }
        public double Quantity { get; set; }
    }
}