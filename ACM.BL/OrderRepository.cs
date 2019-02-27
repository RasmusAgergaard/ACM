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
            //A new object is created to hold the retrived values
            Order order = new Order(orderId);

            //Temp hard coded values to return a populated order
            if (orderId == 10)
            {
                //You need to add the DateTimeOffset here
                //order.OrderDate = new DateTimeOffset(2014, 8, 8, 4, 30, 30, )
            }

            return order;
        }

        public OrderDisplay RetriveOrderDisplay(int orderId)
        {
            OrderDisplay orderDisplay = new OrderDisplay();

            //Temp hardcoded data - Should be a database call of something
            if (orderId == 10)
            {
                orderDisplay.FirstName = "Ole";
                orderDisplay.LastName = "Hansen";
                orderDisplay.OrderDate = new DateTimeOffset(2014, 4, 14, 14, 14, 14, new TimeSpan());
                orderDisplay.ShippingAddress = new Address()
                {
                    AddressType = 1,
                    StreetLine1 = "Road",
                    StreetLine2 = "34B",
                    City = "Small-town",
                    State = "Sooner state",
                    Country = "USA",
                    PostalCode = "144"
                };
            }

            orderDisplay.orderDisplayItemList = new List<OrderDisplayItem>();

            //Temp hardcoded data - Should be a database call of something
            if (orderId == 10)
            {
                var orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Rice",
                    PurchasePrice = 6M,
                    OrderQuantity = 1
                };
                orderDisplay.orderDisplayItemList.Add(orderDisplayItem);

                orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Rake",
                    PurchasePrice = 6M,
                    OrderQuantity = 1
                };
                orderDisplay.orderDisplayItemList.Add(orderDisplayItem);
            }

            return orderDisplay;
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
