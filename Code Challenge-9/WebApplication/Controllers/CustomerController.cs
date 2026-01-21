using System.Linq;
using System.Web.Http;
using System.Data.Entity; 
using WebApplication.Models; 

namespace WebApplication.Controllers
{
    [RoutePrefix("api/customers")]
    public class CustomerController : ApiController
    {
        private readonly NorthWindEntities1 _context;

        public CustomerController()
        {
            _context = new NorthWindEntities1();
        }

        
        [HttpGet]
        [Route("by-country")]
        public IHttpActionResult GetCustomersByCountry(string country)
        {
            if (string.IsNullOrWhiteSpace(country))
                return BadRequest("country is required.");

            

            var customers = _context.Customers
                                    .SqlQuery("EXEC GetCustomersByCountry @p0", country)
                                    .ToList();
       return Ok(customers);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing) _context.Dispose();
            base.Dispose(disposing);
        }
    }
}

