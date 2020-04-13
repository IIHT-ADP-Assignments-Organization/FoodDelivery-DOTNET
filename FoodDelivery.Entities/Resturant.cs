using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Entities
{
    public class Resturant
    {
        public virtual  int ResturantId { get; set; }
        public virtual string ResturantName { get; set; }
        public virtual string Address { get; set; }
        public virtual long PhoneNumber { get; set; }
        public virtual int MenuId { get; set; }

    }
}
