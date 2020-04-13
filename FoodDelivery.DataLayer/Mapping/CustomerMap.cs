using FluentNHibernate.Mapping;
using FoodDelivery.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.DataLayer.Mapping
{
    class CustomerMap: ClassMap<Customer>
    {
        public CustomerMap()
        {
            Id(x => x.CustomerId);
            Map(x => x.PhoneNumber);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.Email);
            Map(x => x.Password);
            Map(x => x.PaymentId);
            Map(x => x.FoodId);
            Map(x => x.Address);

            Table("admin");

        }
    }
}
