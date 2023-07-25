using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using WebApiHotel.Data;
using WebApiHotel.Models;

namespace WebApiHotel.Contollers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartamentController : ControllerBase
    {

        private readonly WebApiHotelContext _context;

        public ApartamentController(WebApiHotelContext context)
        {
            _context = context;
        }

    
        // GET: api/Apartament
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Categoriapartament>>> GetApartament()
        {
            if (_context.Categoriapartaments == null)
            {
                return NotFound();
            }
            return await _context.Categoriapartaments.ToListAsync();
        }
    }
}



