using BackAmadeus.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackAmadeus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LaptopController : ControllerBase
    {
        
        private readonly AplicationDBContext _context;

        public LaptopController(AplicationDBContext context) {
         _context = context;
        }

        // GET: api/<LaptopController>
        [HttpGet]
        public async Task<IActionResult>  Get()
        {
            try
            {
                var listLaptops = await _context.laptop.ToListAsync();
                return Ok(listLaptops);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }


      

        // POST api/<LaptopController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Laptop laptop)
        {
            try
            {
                _context.Add(laptop);
                await _context.SaveChangesAsync(); 
                return Ok(laptop);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<LaptopController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Laptop laptop)
        {
            try
            {
                if(id !=laptop.id) 
                    {
                    return NotFound();
                }
                _context.Update(laptop);
                await _context.SaveChangesAsync();  
                return Ok(new {message = "The laptop was successfully upgraded!" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<LaptopController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var laptop = await _context.laptop.FindAsync(id);
                if(laptop == null)
                {
                    return NotFound();
                }
                _context.laptop.Remove(laptop);   
                await _context.SaveChangesAsync();
                return Ok(new { message = "The laptop was successfully deleted!" });
            }
            catch (Exception ex)
      
                {
                return BadRequest(ex.Message);
            }
        }
    }
}
