using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Entities
{
    public class Payment
    {
        public virtual int PaymentId { get; set; }
        public virtual int CustomerId { get; set; }
        public virtual int OrderId { get; set; }
        public virtual DateTime PaymentDate { get; set; }
        public virtual int Amount { get; set; }
        public virtual string PaymentType { get; set; }

    }
}
