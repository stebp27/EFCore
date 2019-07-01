using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePattern.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipDate { get; set; }
        public decimal Price { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public Order() { }

        public Order(int id, string orderNumber, DateTime orderDate, string shipDate, decimal price, int customerId)
        {
            Id = id;
            OrderNumber = orderNumber;
            OrderDate = orderDate;
            ShipDate = shipDate;
            Price = price;
            CustomerId = customerId;
        }
    }
}
