using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : ControllerBase
    {


        private readonly DataContext _context;

        public WeatherController(DataContext context)
        {
            this._context = context;


        }



        [HttpGet]
        public async Task<ActionResult<IEnumerable<Weather>>> Get()
        {
            var values = await _context.Weathers.ToListAsync();
            return Ok(values);
           
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Weather>> Get(int id)
        {
            var values = await _context.Weathers.FindAsync(id);
            return Ok(values);
           
        }
    }
}
