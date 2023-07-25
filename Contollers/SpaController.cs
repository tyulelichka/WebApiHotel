using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiHotel.Data;
using WebApiHotel.Models;

namespace WebApiHotel.Contollers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpahotelController : ControllerBase
    {

        private readonly WebApiHotelContext _context;

        public SpahotelController(WebApiHotelContext context)
        {
            _context = context;
        }

        // GET: api/Spahotel
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Spahotel>>> GetSpahotel()
        {
            if (_context.Spahotels == null)
            {
                return NotFound();
            }
            return await _context.Spahotels.ToListAsync();
        }

      
        




    }
}
