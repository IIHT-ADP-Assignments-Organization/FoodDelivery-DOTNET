using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Test.Exceptions
{
   public class ResturantNotFoundException:Exception
    {
        public string Messages = " Resturant Not Found  ";

        public ResturantNotFoundException(string message)
        {
            Messages = message;
        }
    }
}
