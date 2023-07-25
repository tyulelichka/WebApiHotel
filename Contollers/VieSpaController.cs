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
    public class ViewSpaController : ControllerBase
    {

        private readonly WebApiHotelContext _context;

        public ViewSpaController(WebApiHotelContext context)
        {
            _context = context;
        }

       

        [HttpGet("getActive")]
        public IActionResult GetViewSpas(int? Id, string? Стать, int? Ціна, int? КількістьВідвідуванняСпа)
        {
            var _ViewSpas = _context.ViewSpas.AsQueryable();
            if (Id != null)
            {
                _ViewSpas = _ViewSpas.Where(a => a.Id == Id);
            }
            if (Стать != null)
            {
                _ViewSpas = _ViewSpas.Where(a => a.Стать == Стать);
            }

            if (Ціна != null)
            {
                _ViewSpas = _ViewSpas.Where(a => a.Ціна == Ціна);
            }

            if (КількістьВідвідуванняСпа != null)
            {
                _ViewSpas = _ViewSpas.Where(a => a.КількістьВідвідуванняСпа == КількістьВідвідуванняСпа);
            }

            var ViewApartaments = _ViewSpas.ToList();

            if (ViewApartaments.Count == 0)
            {
                return NotFound();
            }

            return Ok(ViewApartaments);
        }

    }


}
