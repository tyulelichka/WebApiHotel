using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;
using System.Drawing;
using WebApiHotel.Data;
using WebApiHotel.Models;

namespace WebApiHotel.Contollers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViewApartamentController : ControllerBase
    {

        private readonly WebApiHotelContext _context;

        public ViewApartamentController(WebApiHotelContext context)
        {
            _context = context;
        }


        [HttpGet("getActive")]
        public IActionResult GetViewApartaments(int? Id,string? Стать, int? Ціна, string? КатегоріяАпартаментів, int? КількістьРазівВідпочинку)
        {
            var _ViewApartaments = _context.ViewApartaments.AsQueryable();
            if (Id != null)
            {
                _ViewApartaments = _ViewApartaments.Where(a => a.Id == Id);
            }
            if (Стать != null)
            {
                _ViewApartaments = _ViewApartaments.Where(a => a.Стать == Стать);
            }

            if (Ціна != null)
            {
                _ViewApartaments = _ViewApartaments.Where(a => a.Ціна == Ціна);
            }

            if (КатегоріяАпартаментів != null)
            {
                _ViewApartaments = _ViewApartaments.Where(a => a.КатегоріяАпартаментів == КатегоріяАпартаментів);
            }

            if (КількістьРазівВідпочинку != null)
            {
                _ViewApartaments = _ViewApartaments.Where(a => a.КількістьРазівВідпочинку == КількістьРазівВідпочинку);
            }

            var ViewApartaments = _ViewApartaments.ToList();

            if (ViewApartaments.Count == 0)
            {
                return NotFound();
            }

            return Ok(ViewApartaments);
        }
      
    }
}
