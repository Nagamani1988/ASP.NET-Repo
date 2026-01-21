using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class CountryController : ApiController
    {
         static List<Country> countries = new List<Country>()
        {
            new Country { ID = 1, CountryName = "India", Capital = "New Delhi" },
            new Country { ID = 2, CountryName = "USA", Capital = "Washington DC" }
        };

            
            [HttpGet]
            public IHttpActionResult GetAllCountries()
            {
                return Ok(countries);
            }

            
            [HttpGet]
            public IHttpActionResult GetCountryById(int id)
            {
                var country = countries.FirstOrDefault(c => c.ID == id);
                if (country == null)
                    return NotFound();

                return Ok(country);
            }

            
            [HttpPost]
            public IHttpActionResult AddCountry(Country country)
            {
                countries.Add(country);
                return Ok(country);
            }

            
            [HttpPut]
            public IHttpActionResult UpdateCountry(int id, Country country)
            {
                var existing = countries.FirstOrDefault(c => c.ID == id);
                if (existing == null)
                    return NotFound();

                existing.CountryName = country.CountryName;
                existing.Capital = country.Capital;

                return Ok(existing);
            }

            
            [HttpDelete]
            public IHttpActionResult DeleteCountry(int id)
            {
                var country = countries.FirstOrDefault(c => c.ID == id);
                if (country == null)
                    return NotFound();

                countries.Remove(country);
                return Ok("Country deleted successfully");
            }
        }
    }



