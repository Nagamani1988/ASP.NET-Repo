using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class CustomerAndOrder
    {

        public class OrderDto
        {
            public int OrderID { get; set; }
            public string CustomerID { get; set; }
            public int? EmployeeID { get; set; }
            public DateTime? OrderDate { get; set; }
            public string ShipCountry { get; set; }
        }

        public class CustomerDto
        {
            public string CustomerID { get; set; }
            public string CompanyName { get; set; }
            public string ContactName { get; set; }
            public string Country { get; set; }
            public string City { get; set; }
        }

    }
}