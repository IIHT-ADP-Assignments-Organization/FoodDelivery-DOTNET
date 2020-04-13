using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Test.Exceptions
{
    public class UserNotFoundException:Exception
    {
        public string Messages = " User Not Found  ";

        public UserNotFoundException(string message)
        {
            Messages = message;
        }
    }
}
