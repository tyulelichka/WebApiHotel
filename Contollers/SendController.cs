using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;
using WebApiHotel.Data;
using WebApiHotel.Models;

namespace WebApiHotel.Contollers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendController : ControllerBase
    {
        private readonly WebApiHotelContext _context;

        public SendController(WebApiHotelContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Offerhotel>> SendMessage(Offerhotel contract, int? id)
        {
            var _Newsletterss = _context.Newsletters.AsQueryable();
            EmailService emailService = new EmailService();
            await emailService.SendEmailAsync("viktoria3003vita@gmail.com",
                "Розсилка пропозицій від ГКК", 
                $"{_Newsletterss.Where(a => a.IdNewsletter == id)}");
            return RedirectToAction("Index");




        }



        //[HttpPost]
        //public async Task<ActionResult<Offerhotel>> PostContract(Offerhotel contract)
        //{
        //    if (_context.Offerhotels == null)
        //    {
        //        return Problem("Entity set 'WebApiTourContext.Contracts'  is null.");
        //    }
        //    _context.Offerhotels.Add(contract);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetContract", new { _Newsletterss.Where(a => a.IdNewsletter == id) }, contract);
        //}

    }
}
