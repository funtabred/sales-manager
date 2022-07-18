using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales_Management___Project.Entities
{
    public struct Order
    {
        public string orderId;
        public DateTime createdAt;
        public List<OrderDetail> orderDetails;
    }
}
