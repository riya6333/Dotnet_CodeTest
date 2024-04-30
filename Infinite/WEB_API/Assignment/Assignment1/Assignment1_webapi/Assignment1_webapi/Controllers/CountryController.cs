using Assignment1_webapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_webapi.Controllers
{
    public class CountryController : ApiController
    {
        static List<Country> countryList = new List<Country>()
        {
            new Country { ID = 1, CountryName = "USA", Capital = "Washington D.C." },
            new Country { ID = 2, CountryName = "UK", Capital = "London" },
            new Country { ID = 3, CountryName = "France", Capital = "Paris" }
        };

        // GET: api/Country/All
        [HttpGet]
        [Route("All")]
        public IEnumerable<Country> Get()
        {
            return countryList;
        }

        // GET: api/Country/ById?id=1
        [HttpGet]
        [Route("ById")]
        public IHttpActionResult GetById(int id)
        {
            var country = countryList.FirstOrDefault(c => c.ID == id);
            if (country == null)
            {
                return NotFound();
            }
            return Ok(country);
        }

        // POST: api/Country/Create
        [HttpPost]
        [Route("Create")]
        public IHttpActionResult Create(Country country)
        {
            countryList.Add(country);
            return Ok(countryList);
        }

        // PUT: api/Country/Update?id=1
        [HttpPut]
        [Route("Update")]
        public IHttpActionResult Update(int id, Country country)
        {
            var existingCountry = countryList.FirstOrDefault(c => c.ID == id);
            if (existingCountry == null)
            {
                return NotFound();
            }
            existingCountry.CountryName = country.CountryName;
            existingCountry.Capital = country.Capital;
            return Ok(countryList);
        }

        // DELETE: api/Country/Delete?id=1
        [HttpDelete]
        [Route("Delete")]
        public IHttpActionResult Delete(int id)
        {
            var country = countryList.FirstOrDefault(c => c.ID == id);
            if (country == null)
            {
                return NotFound();
            }
            countryList.Remove(country);
            return Ok(countryList);
        }
    }
}