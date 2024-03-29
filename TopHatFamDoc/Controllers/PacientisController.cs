﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using TopHatFamDoc.Models;

namespace TopHatFamDoc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacientisController : ControllerBase
    {
        private readonly AuthenticationContext _context;

        public PacientisController(AuthenticationContext context)
        {
            _context = context;
        }

        // GET: api/Pacientis
        [HttpGet]
        public IEnumerable<Pacienti> GetPacienti([FromQuery] string search)
        {

            string userId = User.Claims.First(c => c.Type == "UserID").Value;
            var pacienti = from n in _context.Pacienti
                           select n;
            pacienti = pacienti.Where(p => p.UserID.Equals(userId));
            if (!String.IsNullOrEmpty(search))
            {
                pacienti = pacienti.Where(p => p.Nume.Contains(search) || p.Prenume.Contains(search));
                
                                    
            }
            return pacienti;


        }

        // GET: api/Pacientis/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPacienti([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var pacienti = await _context.Pacienti.FindAsync(id);

            if (pacienti == null)
            {
                return NotFound();
            }

            return Ok(pacienti);
        }

     

        // PUT: api/Pacientis/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPacienti([FromRoute] int id, [FromBody] Pacienti pacienti)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pacienti.id)
            {
                return BadRequest();
            }

            _context.Entry(pacienti).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PacientiExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Pacientis
        [HttpPost]
        public async Task<IActionResult> PostPacienti([FromBody] Pacienti pacienti)
        {
            string userId = User.Claims.First(c => c.Type == "UserID").Value;
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            pacienti.UserID = userId;
            pacienti.DataInregistrare = DateTime.Today;
            _context.Pacienti.Add(pacienti);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPacienti", new { id = pacienti.id }, pacienti);
        }

        // DELETE: api/Pacientis/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePacienti([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var pacienti = await _context.Pacienti.FindAsync(id);
            if (pacienti == null)
            {
                return NotFound();
            }

            _context.Pacienti.Remove(pacienti);
            await _context.SaveChangesAsync();

            return Ok(pacienti);
        }

        private bool PacientiExists(int id)
        {
            return _context.Pacienti.Any(e => e.id == id);
        }

}
}