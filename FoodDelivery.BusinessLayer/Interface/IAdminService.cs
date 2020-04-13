using FoodDelivery.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.BusinessLayer.Interface
{
     public interface IAdminService
    {
        Admin Register(Admin admin);
        bool Login(string UserName, string Password);
        int AddFoodItem(FoodItem fooditem);
        FoodItem UpdateFoodItem(FoodItem fooditem);
        FoodItem GetFoodItem(int Id);
        bool DeleteFoodItem(int FoodId);
        int AddResturant(Resturant resturant);
        Resturant UpdateResturant(Resturant resturant);
        Resturant GetResturant(int ResurantId);
        bool DeleteResturant(int ResturantId);
        int AddDeliveryPerson(DeliveryPerson deliveryperson);
        DeliveryPerson UpdateDeliveryPerson(DeliveryPerson deliveryperson);
        DeliveryPerson GetDeliveryPerson(int DeliveryId);
        bool DeleteDeliveryPerson(int Id);
        int AddMenu(Menu menu);
        Menu UpdateMenu(Menu menu);
        Menu GetMenu(int MenuId);
        bool DeleteMenu(int MenuId);
        Order SearchOrder(int OrderId);
        string UpdateOrderStatus(string Status);
        DeliveryPerson AssignOrdertoDeliveryPerson(int DeliveryPersonId, int intOrderId, int CustomerId);
    }
}
