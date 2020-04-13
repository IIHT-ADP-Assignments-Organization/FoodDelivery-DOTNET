using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Entities
{
    public class Order
    {
        public virtual int OrderId { get; set; }
        public virtual DateTime OrderDate { get; set; }
        public virtual  int Quantity { get; set; }
        public virtual DateTime PickupDate { get; set; }
        public virtual string Status { get; set; }
    }
}
