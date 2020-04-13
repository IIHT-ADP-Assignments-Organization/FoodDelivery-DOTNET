using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Entities
{
    public class Menu
    {
        public virtual int MenuId { get; set; }
        public virtual int FoodId { get; set; }
        public virtual int Price { get; set; }
        public virtual  DateTime StartDate { get; set; }
        public virtual DateTime EndDate { get; set; }

    }
}
