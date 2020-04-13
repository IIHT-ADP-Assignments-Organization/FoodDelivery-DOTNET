using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Entities
{
    public class FoodItem
    {
        public virtual int FoodId { get; set; }
        public virtual string Name { get; set; }
        public virtual int Quantity { get; set; }
        public virtual int UnitPrice { get; set; }
        public virtual string ItemCtegory { get; set; }

    }
}
