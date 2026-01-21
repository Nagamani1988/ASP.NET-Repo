using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApplication;         
using WebApplication.Models;   


[RoutePrefix("api/orders")]
public class OrdersController : ApiController
{
    private readonly NorthWindEntities1 _db = new NorthWindEntities1();

    
    [HttpGet]
    [Route("by-employee/{employeeId:int}")]
    public IHttpActionResult GetOrdersByEmployee(int employeeId)
    {
        var orders = _db.Orders
            .Where(o => o.EmployeeID == employeeId)
            .Select(o => new 
            {
                OrderID = o.OrderID,
                CustomerID = o.CustomerID,
                EmployeeID = o.EmployeeID,
                OrderDate = o.OrderDate,
                ShipCountry = o.ShipCountry
            })
            .ToList();

        return Ok(orders);
    }
}

