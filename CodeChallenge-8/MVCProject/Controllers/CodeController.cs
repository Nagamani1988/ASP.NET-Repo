using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MVCProject.Models;

namespace MVCProject.Controllers
{
    public class CodeController : Controller
    {
        NorthWindEntities db = new NorthWindEntities();  

        public ActionResult GermanyCustomers()
        {
            var customers = db.Customers
                              .Where(c => c.Country == "Germany")
                              .ToList();
            return View(customers);
        }

        public ActionResult CustomerOrder()
        {
            var customer = db.Orders
                             .Where(o => o.OrderID == 10248)
                             .Select(o => o.Customer)
                             .FirstOrDefault();
            return View(customer);
        }
    }
}
