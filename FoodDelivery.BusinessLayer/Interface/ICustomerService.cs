using FoodDelivery.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.BusinessLayer.Interface
{
    public interface ICustomerService
    {
        Customer Register(Customer customer);
        bool Login(string Email, string Password);
        Resturant SearchResturant(string ResturantName);
        Order ViewOrder();
        int AddToCart(Cart cart);
        Cart ViewCart();
        Order PlaceOrder(Order order);
        Payment MakePayment(Payment payment);

    }
}
