using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Entities
{
    public class Cart
    {
        public virtual int CartId { get; set; }
        public virtual int CustomerId { get; set; }
        public virtual int FoodId { get; set; }
        public virtual int Quantity { get; set; }
        public virtual int TotalPrice { get; set; }

    }
}
