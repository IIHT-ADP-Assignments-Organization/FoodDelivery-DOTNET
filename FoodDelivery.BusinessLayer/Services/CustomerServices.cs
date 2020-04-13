using FoodDelivery.BusinessLayer.Interface;
using FoodDelivery.DataLayer.NHibernateConfiguration;
using FoodDelivery.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.BusinessLayer.Services
{
    public class CustomerServices : ICustomerService
    {
        private readonly IMapperSession _session;

        public CustomerServices(IMapperSession session)
        {
            _session = session;
        }

        public int AddToCart(Cart cart)
        {
            Cart ObjCart = new Cart();
            return ObjCart.CartId;
        }

        public bool Login(string Email, string Password)
        {
            return true;
        }

        public Payment MakePayment(Payment payment)
        {
            Payment ObjPayment = new Payment();
            return ObjPayment;
        }

        public Order PlaceOrder(Order order)
        {
            Order ObjOrder = new Order();
            return ObjOrder;
        }

        public Customer Register(Customer customer)
        {
            Customer ObjCustomer = new Customer();
            return ObjCustomer;
        }

        public Resturant SearchResturant(string ResturantName)
        {
            Resturant resturant = new Resturant();
            return resturant;
        }

        public Cart ViewCart()
        {
            Cart cart = new Cart();
            return cart;
        }

        public Order ViewOrder()
        {
            Order order = new Order();
            return order;
        }
    }
}
