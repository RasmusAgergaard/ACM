using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        /// <summary>
        /// Retrieve one order
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            if (orderId == 10)
            {
                //You need to add the DateTimeOffset here
                //order.OrderDate = new DateTimeOffset(2014, 8, 8, 4, 30, 30, )
            }

            return order;
        }

        /// <summary>
        /// Saves the current order
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            //Code that saves the defined order
            return true;
        }
    }
}
