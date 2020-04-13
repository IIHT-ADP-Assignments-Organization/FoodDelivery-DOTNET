using FoodDelivery.BusinessLayer.Interface;
using FoodDelivery.DataLayer.NHibernateConfiguration;
using FoodDelivery.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.BusinessLayer.Services
{
    public class AdminServices : IAdminService
    {

        private readonly IMapperSession _session;

        public AdminServices(IMapperSession session)
        {
            _session = session;
        }
        public int AddDeliveryPerson(DeliveryPerson deliveryperson)
        {
            DeliveryPerson ObjDeliveryPerson = new DeliveryPerson();
            return ObjDeliveryPerson.Id;
        }

        public int AddFoodItem(FoodItem fooditem)
        {
            FoodItem foodItem = new FoodItem();
            return foodItem.FoodId;
        }

        public int AddMenu(Menu menu)
        {
            Menu ObjMenu = new Menu();
            return ObjMenu.MenuId;
        }

        public int AddResturant(Resturant resturant)
        {
            Resturant ObjResturant = new Resturant();
            return ObjResturant.ResturantId;
        }

        public DeliveryPerson AssignOrdertoDeliveryPerson(int DeliveryPersonId, int intOrderId, int CustomerId)
        {
            DeliveryPerson deliveryPerson = new DeliveryPerson();
            return deliveryPerson;
        }

        public bool DeleteDeliveryPerson(int Id)
        {
            return true;
        }

        public bool DeleteFoodItem(int FoodId)
        {
            return true;
        }

        public bool DeleteMenu(int MenuId)
        {
            return true;
        }

        public bool DeleteResturant(int ResturantId)
        {
            return true;
        }

        public DeliveryPerson GetDeliveryPerson(int DeliveryId)
        {
            DeliveryPerson deliveryPerson = new DeliveryPerson();
            return deliveryPerson;
        }

        public FoodItem GetFoodItem(int Id)
        {
            FoodItem foodItem = new FoodItem();
            return foodItem;
        }

        public Menu GetMenu(int MenuId)
        {
            Menu ObjMenu = new Menu();
            return ObjMenu;
        }

        public Order GetOrderStatus(int OrderId)
        {
            Order order = new Order();
            return order;
        }

        public Resturant GetResturant(int ResurantId)
        {
            Resturant resturant = new Resturant();
            return resturant;
        }

        public bool Login(string UserName, string Password)
        {
            return true;
        }

        public Admin Register(Admin admin)
        {
            Admin ObjAdmin = new Admin();
            return ObjAdmin;
        }

        public Order SearchOrder(int OrderId)
        {
            Order order = new Order();
            return order;
        }

        public DeliveryPerson UpdateDeliveryPerson(DeliveryPerson deliveryperson)
        {
            DeliveryPerson deliveryPerson = new DeliveryPerson();
            return deliveryPerson;
        }

        public FoodItem UpdateFoodItem(FoodItem fooditem)
        {
            FoodItem foodItem = new FoodItem();
            return foodItem;
        }

        public Menu UpdateMenu(Menu menu)
        {
            Menu ObjMenu = new Menu();
            return ObjMenu;
        }

        public string UpdateOrderStatus(string Status)
        {
            Order order = new Order();
            return order.Status;
        }

        public Resturant UpdateResturant(Resturant resturant)
        {
            Resturant Objresturant = new Resturant();
            return Objresturant;
        }
    }
}
