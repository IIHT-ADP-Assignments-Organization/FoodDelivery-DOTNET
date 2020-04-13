using FoodDelivery.BusinessLayer.Services;
using FoodDelivery.DataLayer.NHibernateConfiguration;
using FoodDelivery.Entities;
using FoodDelivery.Test.Exceptions;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FoodDelivery.Test.TestCases
{
   public class ExceptionTest
    {
        private readonly CustomerServices _CustomerServices;
        private readonly AdminServices _AdminServices;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public ExceptionTest()
        {
            _CustomerServices = new CustomerServices(_session);
            _AdminServices = new AdminServices(_session);
        }

        [Fact]
        public void ExceptionTestFor_EmailNotFoundforCustomer()
        {
            Customer user = new Customer()
            {
                Email = "abc",
                Password = ""

            };
            //Assert
            var ex = Assert.Throws<UserNotFoundException>(() => _CustomerServices.Login(user.Email, user.Password));
            Assert.Equal("User Not Found ", ex.Messages);
        }

        [Fact]
        public void ExceptionTestFor_ResturantNotFound()
        {
            Resturant resturant = new Resturant()
            {
               
                ResturantName = "",
            };
            //Assert
            var ex = Assert.Throws<ResturantNotFoundException>(() => _CustomerServices.SearchResturant(resturant.ResturantName));
            Assert.Equal("Resturant Not Found  ", ex.Messages);
        }

        [Fact]
        public void ExceptionTestFor_FieldsCannotblank()
        {
            Customer user = new Customer()
            {
                FirstName="",
                Email = "abc",
                Password = ""

            };
            //Assert
            var ex = Assert.Throws<FieldscannotEmptyException>(() => _CustomerServices.Register(user));
            Assert.Equal("Fields can not be blank ", ex.Messages);
        }

        [Fact]
        public void ExceptionTestFor_OrderNotFound()
        {
            Resturant resturant = new Resturant()
            {

                ResturantName = "",
            };
            //Assert
            var ex = Assert.Throws<OrderNotFoundException>(() => _CustomerServices.SearchResturant(resturant.ResturantName));
            Assert.Equal("Order Not Found ", ex.Messages);
        }

        [Fact]
        public void ExceptionTestFor_UserNotFoundforAdmin()
        {
            Admin user = new Admin()
            {
                UserName = "abc",
                Password = ""

            };
            //Assert
            var ex = Assert.Throws<UserNotFoundException>(() => _AdminServices.Login(user.UserName, user.Password));
            Assert.Equal("User Not Found ", ex.Messages);
        }
    }
}
