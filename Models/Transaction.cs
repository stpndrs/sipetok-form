using System;
using System.Collections.Generic;
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
        public PaymentState PaymentStatus { get; set; } = PaymentState.WaitingForPayment;
        public OrderState OrderStatus { get; set; } = OrderState.OrderComeIn;
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerPhoneNumber { get; set; } = string.Empty;
        public virtual ICollection<TransactionDetail> Details { get; set; } = new List<TransactionDetail>();
        public int TenantId { get; set; }

        public virtual Tenant? Tenant { get; set; }

        public Transaction() { }

        public Transaction(int Id, decimal PaymentAmount, PaymentState PaymentStatus, OrderState OrderStatus, decimal TotalPrice, int TenantId, string CustomerName, string CustomerPhoneNumber)
        {
            this.Id = Id;
            this.Date = DateTime.Now;
            this.PaymentAmount = PaymentAmount;
            this.TotalPrice = TotalPrice;
            this.TenantId = TenantId;
            this.PaymentStatus = PaymentStatus;
            this.OrderStatus = OrderStatus;
            this.CustomerName = CustomerName;
            this.CustomerPhoneNumber = CustomerPhoneNumber;
        }
    }

    public enum OrderState
    {
        OrderComeIn,
        ReadyForPickup,
        Completed,
        Cancelled
    }

    public enum PaymentState
    {
        WaitingForPayment,
        Success,
        Cancelled
    }
}
