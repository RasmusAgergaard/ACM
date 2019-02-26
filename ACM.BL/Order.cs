﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            this.OrderId = orderId;
        }

        public DateTimeOffset? OrderDate { get; set; } //The '?' makes this propperty nullable
        public int OrderId { get; private set; }

        /// <summary>
        /// Validates the order data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            bool isValid = true;

            if (OrderDate == null)
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
