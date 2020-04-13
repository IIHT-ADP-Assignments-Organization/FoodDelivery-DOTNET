using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Entities
{
    public class Customer
    {
        public virtual int CustomerId { get; set; }
        public virtual string Email { get; set; }
        public virtual long PhoneNumber { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Password { get; set; }
        public virtual int PaymentId { get; set; }
        public virtual int FoodId { get; set; }
        public virtual string Address { get; set; }
    }
}
