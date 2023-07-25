using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WebApiHotel.Data;
using WebApiHotel.Models;

namespace WebApiHotel.Contollers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserhotelController : ControllerBase
    {

        private readonly WebApiHotelContext _context;

        public UserhotelController(WebApiHotelContext context)
        {
            _context = context;
        }
        // GET: api/Userhotel
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Userhotel>>> GetUserhotel()
        {
            if (_context.Userhotels == null)
            {
                return NotFound();
            }
            return await _context.Userhotels.ToListAsync();
        }       
    }
}
