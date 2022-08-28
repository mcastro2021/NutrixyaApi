using Microsoft.AspNetCore.Mvc;
using NutrixyaApi.Db;
using NutrixyaApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NutrixyaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LotController : ControllerBase
    {
        // GET: api/<LotController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<Lot>? lots;
                using (Context context = new())
                {

                    lots = context.Lots.ToList();
                }

                return Ok(lots.ToList());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET api/<LotController>/5
        [HttpGet("{id}")]
        public Lot Get(int id)
        {
            Lot lot;
            using (Context context = new())
            {

                lot = context.Lots.Where(l => l.Id == id).FirstOrDefault();
            }

            return lot;
        }

        // POST api/<LotController>
        [HttpPost]
        public void Post(Lot value)
        {

            using (Context context = new())
            {

                context.Lots.Add(value);
                context.SaveChanges();
            }


        }

        // PUT api/<LotController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LotController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
