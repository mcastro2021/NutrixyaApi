using Microsoft.AspNetCore.Mvc;
using NutrixyaApi.Db;
using NutrixyaApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NutrixyaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        // GET: api/<City>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<City>? city;
                using (Context context = new())
                {

                    city = context.Cities.ToList();
                }

                return Ok(city.ToList());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET api/<City>/5

        [HttpGet("{id}")]
        public string? Get(int id)
        {
            City city;
            using (Context context = new())
            {

                city = context.Cities.Where(c => c.Id == id).FirstOrDefault();
            }

            return city?.Description;
        }

        // POST api/<Provinces>
        [HttpPost]
        public void Post(City value)
        {

            using (Context context = new())
            {

                context.Cities.Add(value);
                context.SaveChanges();
            }

        }
        // PUT api/<CityController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CityController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
