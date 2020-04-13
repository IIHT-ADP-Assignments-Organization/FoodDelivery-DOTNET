using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Test.Exceptions
{
 public   class OrderNotFoundException:Exception
    {
        public string Messages = " Order Not Found  ";

        public OrderNotFoundException(string message)
        {
            Messages = message;
        }
    }
}
