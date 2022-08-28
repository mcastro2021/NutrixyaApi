using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;
using NutrixyaApi.Db;
using NutrixyaApi.Models;
using System.Diagnostics.Metrics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NutrixyaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        // GET: api/<Countries>
        [HttpGet]
        public IActionResult Get()
        {
            List<Country>? countries;
            using(Context context=new())
            {

                countries = context.Countries.ToList();
            }

            return Ok(countries.ToList());
        }

        // GET: api/<GetProvinces>

        [HttpGet("Provinces")]
        public IActionResult Provinces(int provinceId)
        {
            List<Province>? provinces;
            using (Context context = new())
            {

                provinces = context.Provinces.ToList();
            }

            return Ok(provinces.ToList());
        }


        // GET api/<Countries>/5
        [HttpGet("{id}")]
        public string? Get(int id)
        {
            Country country;
            using (Context context = new())
            {

                country = context.Countries.Where(c => c.Id == id).FirstOrDefault();
            }

            return country?.Description;
        }

        // POST api/<Countries>
        [HttpPost]
        public void Post(Country value)
        {
            Console.WriteLine(value);

            using (Context context = new())
            {

                context.Countries.Add(value);
                context.SaveChanges();
            }

        }

        // PUT api/<Countries>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Countries>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
