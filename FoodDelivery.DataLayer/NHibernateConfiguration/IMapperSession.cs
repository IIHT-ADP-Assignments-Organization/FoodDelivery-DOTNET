﻿using FoodDelivery.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoodDelivery.DataLayer.NHibernateConfiguration
{

    public interface IMapperSession
    {
        void BeginTransaction();
        System.Threading.Tasks.Task Commit();
        System.Threading.Tasks.Task Rollback();
        void CloseTransaction();
        System.Threading.Tasks.Task Save(Customer entity);
        System.Threading.Tasks.Task Delete(Customer entity);
        IQueryable<Customer> customer { get; }
    }
}
