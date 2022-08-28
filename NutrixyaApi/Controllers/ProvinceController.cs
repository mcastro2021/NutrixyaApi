using Microsoft.AspNetCore.Mvc;
using NutrixyaApi.Db;
using NutrixyaApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NutrixyaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinceController : ControllerBase
    {
        // GET: api/<Province>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<Province>? provinces;
                using (Context context = new())
                {

                    provinces = context.Provinces.ToList();
                }

                return Ok(provinces.ToList());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET api/<Provinces>/5

        [HttpGet("{id}")]
        public string? Get(int id)
        {
            Province province;
            using (Context context = new())
            {

                province = context.Provinces.Where(c => c.Id == id).FirstOrDefault();
            }

            return province?.Description;
        }

        // POST api/<Provinces>
        [HttpPost]
        public void Post(Province value)
        {   

            using (Context context = new())
            {

                context.Provinces.Add(value);
                context.SaveChanges();
            }

        }

        // PUT api/<ProvinceController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProvinceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
