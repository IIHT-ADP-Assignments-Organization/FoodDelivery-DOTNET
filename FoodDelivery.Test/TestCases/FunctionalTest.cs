using FoodDelivery.BusinessLayer.Services;
using FoodDelivery.DataLayer.NHibernateConfiguration;
using FoodDelivery.Entities;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FoodDelivery.Test.TestCases
{
  public  class FunctionalTest
    {
        private readonly CustomerServices _CustomerServices;
        private readonly AdminServices _AdminServices;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public FunctionalTest()
        {
            _CustomerServices = new CustomerServices(_session);
            _AdminServices = new AdminServices(_session);
        }

		[Fact]
		public void TestFor_Valid_Register()
		{
			//Arrange
			Admin admin = new Admin()
			{
				AdminId = 1,
				FirstName = "Asha",
				LastName = "N",
				UserName = "Asha123",
				Password = "12345678",
				MenuId = 4

			};
			//Action
			var IsRegistered = _AdminServices.Register(admin);
			//Assert
			Assert.NotNull(IsRegistered);
		}
		[Fact]

		public void TestFor_Valid_Login()
		{
			//Arrange
			Admin admin = new Admin()
			{

				UserName = "Asha123",
				Password = "12345678",

			};
			//Action
			var IsLogined = _AdminServices.Login(admin.UserName,admin.Password);
			//Assert
			Assert.True(IsLogined);
		}

		[Fact]
		public void TestFor_AddFoodItem()
		{
			FoodItem foodItem = new FoodItem()
			{
				FoodId = 1,
				Name = "FriedRice",
				Quantity = 50,
				UnitPrice = 70,
				ItemCtegory =" rice"
			};
		var IsAdded = _AdminServices.AddFoodItem(foodItem);
			var Result = IsAdded.ToString();
			//Assert
			Assert.NotNull(Result);
		}

		[Fact]
		public void TestFor_UpdateFoodItem()
		{
			FoodItem foodItem = new FoodItem()
			{
				FoodId = 1,
				Name = "FriedRice",
				Quantity = 50,
				UnitPrice = 70,
				ItemCtegory = "rice"
			};
		var IsUpdated = _AdminServices.UpdateFoodItem(foodItem);
			var GetUpdated = _AdminServices.GetFoodItem(foodItem.FoodId);
			//Assert
			Assert.Equal(IsUpdated, GetUpdated);
		}

		[Fact]
		public void TestFor_DeleteFoodItem()
		{
			FoodItem foodItem = new FoodItem()
			{
				FoodId = 1,

			};
			var IsDeleted = _AdminServices.DeleteFoodItem(foodItem.FoodId);

			//Assert
			Assert.True(IsDeleted);
		}

		[Fact]
		public void TestFor_AddResturant()
		{
			Resturant resturant = new Resturant()
			{
				ResturantId = 3,
				ResturantName = "ravi",
				Address = "bangalore",
				PhoneNumber = 9889787678,
				MenuId = 7

			};
			var IsAdded = _AdminServices.AddResturant(resturant);
			var Result = IsAdded.ToString();
			//Assert
			Assert.NotNull(Result);
		}

		[Fact]
		public void TestFor_UpdateResturant()
		{
			Resturant resturant = new Resturant()
			{
				ResturantId = 3,
				ResturantName = "ravi",
				Address = "bangalore",
				PhoneNumber = 9889787678,
				MenuId = 7
			};
			var IsUpdated = _AdminServices.UpdateResturant(resturant);
			var GetUpdated = _AdminServices.GetResturant(resturant.ResturantId);
			//Assert
			Assert.Equal(IsUpdated, GetUpdated);
		}

		[Fact]
		public void TestFor_DeleteResturant()
		{
			Resturant resturant = new Resturant()
			{
				ResturantId = 3

			};
			var IsDeleted = _AdminServices.DeleteResturant(resturant.ResturantId);

			//Assert
			Assert.True(IsDeleted);
		}

		[Fact]
		public void TestFor_AddDeliveryPerson()
		{
			DeliveryPerson deliveryperson = new DeliveryPerson()
			{
				Id = 3,
				Name = "ravi",
				Address = "bangalore",
				PhoneNumber = 9889787678

			};
			var IsAdded = _AdminServices.AddDeliveryPerson(deliveryperson);
			var Result = IsAdded.ToString();
			//Assert
			Assert.NotNull(Result);
		}

		[Fact]
		public void TestFor_UpdateDeliveryPerson()
		{
			DeliveryPerson deliveryperson = new DeliveryPerson()
			{
				Id = 3,
				Name = "ravi",
				Address = "bangalore",
				PhoneNumber = 9889787678
			};
			var IsUpdated = _AdminServices.UpdateDeliveryPerson(deliveryperson);
			var GetUpdated = _AdminServices.GetDeliveryPerson(deliveryperson.Id);
			//Assert
			Assert.Equal(IsUpdated, GetUpdated);
		}

		[Fact]
		public void TestFor_DeleteDeliveryPerson()
		{
			DeliveryPerson deliveryperson = new DeliveryPerson()
			{
				Id = 3

			};
			var IsDeleted = _AdminServices.DeleteDeliveryPerson(deliveryperson.Id);

			//Assert
			Assert.True(IsDeleted);
		}

		[Fact]
		public void TestFor_AddMenu()
		{
			Menu menu = new Menu()
			{
				MenuId = 2,
				FoodId = 5,
				Price = 100,
				StartDate = DateTime.Now,
				EndDate = DateTime.Now

			};
		var IsAdded = _AdminServices.AddMenu(menu);
			var Result = IsAdded.ToString();
			//Assert
			Assert.NotNull(Result);
		}

		[Fact]
		public void TestFor_UpdateMenu()
		{
			Menu menu = new Menu()
			{
				MenuId = 2,
				FoodId = 5,
				Price = 100,
				StartDate = DateTime.Now,
				EndDate = DateTime.Now

			};
		var IsUpdated = _AdminServices.UpdateMenu(menu);
			var GetUpdated = _AdminServices.GetMenu(menu.MenuId);
			//Assert
			Assert.Equal(IsUpdated, GetUpdated);
		}

		[Fact]
		public void TestFor_DeleteMenu()
		{
			Menu menu = new Menu()
			{
				MenuId = 2
			};
			var IsDeleted = _AdminServices.DeleteMenu(menu.MenuId);

			//Assert
			Assert.True(IsDeleted);
		}

		[Fact]
		public void TestFor_SearchOrder()
		{
			Order order = new Order()
			{
				OrderId = 2
			};
			var IsSeached = _AdminServices.SearchOrder(order.OrderId);

			//Assert
			Assert.NotNull(IsSeached);
		}

		[Fact]
		public void TestFor_UpdateOrderStatus()
		{
			Order order = new Order()
			{
				Status = ""
			};
			var orderstatus = _AdminServices.UpdateOrderStatus(order.Status);

			//Assert
			Assert.NotNull(orderstatus);
		}

		//Customertestcase
		[Fact]
		public void TestFor_Valid_RegisterForCustomer()
		{
			//Arrange
			Customer customer = new Customer()
			{
				CustomerId = 1,
				Email = "Asha123@gmail.com",
				PhoneNumber = 89898778,
				FirstName = "manu",
				LastName = "P",
				Password = "1234",
				PaymentId = 2,
				FoodId = 3,
				Address = ""
			};
			//Action
			var IsRegistered = _CustomerServices.Register(customer);
			//Assert
			Assert.NotNull(IsRegistered);
		}

		[Fact]
		public void TestFor_Valid_LoginforCustomer()
		{
			//Arrange
			Customer customer = new Customer()
			{
				Email = "Asha123@gmail.com",
				Password = "12345678",

			};
			//Action
			var IsLogined = _CustomerServices.Login(customer.Email,customer.Password);
			//Assert
			Assert.True(IsLogined);
		}

		[Fact]
		public void TestFor_SearchResturant()
		{
			Resturant resturant = new Resturant()
			{
				ResturantName = ""
			};
			var IsSeached = _CustomerServices.SearchResturant(resturant.ResturantName);

			//Assert
			Assert.NotNull(IsSeached);
		}

		[Fact]
		public void TestFor_viewOrder()
		{
			Order order = new Order()
			{
				OrderId = 2
			};
			var IsViewed = _CustomerServices.ViewOrder();

			//Assert
			Assert.NotNull(IsViewed);
		}

		[Fact]
		public void TestFor_viewCart()
		{
			Cart cart = new Cart()
			{
				CartId = 2
			};
			var IsViewed = _CustomerServices.ViewCart();

			//Assert
			Assert.NotNull(IsViewed);
		}

		[Fact]
		public void TestFor_AddToCart()
		{
			Cart cart = new Cart()
			{
				CartId = 2,
				CustomerId = 3,
				FoodId = 7,
				Quantity = 10,
				TotalPrice = 100
			};
			var IsAdded = _CustomerServices.AddToCart(cart);
			var Result = IsAdded.ToString();
			//Assert
			Assert.NotNull(Result);
		}

		[Fact]
		public void TestFor_PlaceOrder()
		{
			Order order = new Order()
			{
				OrderId = 2,
				OrderDate = DateTime.Now,
				Quantity = 5,
				PickupDate = DateTime.Now,
				Status = "reached"
			};
			var Isordered = _CustomerServices.PlaceOrder(order);

			//Assert
			Assert.NotNull(Isordered);
		}

		[Fact]
		public void TestFor_MakePayment()
		{
			Payment payment = new Payment()
			{
				PaymentId = 2,
				OrderId = 2,
				CustomerId = 2,
				PaymentDate = DateTime.Now,
				Amount = 500,
				PaymentType = "card"

			};
			var Ispaid = _CustomerServices.MakePayment(payment);

			//Assert
			Assert.NotNull(Ispaid);
		}
	}
}
