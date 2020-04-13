using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Entities
{
    public class DeliveryPerson
    {
        public virtual  int Id { get; set; }
        public virtual  string Name { get; set; }
        public virtual string Address { get; set; }
        public virtual long PhoneNumber { get; set; }

    }
}
