using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Assignment2WebApplication.Data;
using Assignment2WebApplication.Models;

namespace Assignment2WebApplication.API
{
    [Route("api/Suites")]
    [ApiController]
    public class SuitesApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SuitesApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/SuitesApi
        [HttpGet]
        public IEnumerable<Suite> GetSuite()
        {
            return _context.Suite;
        }

        // GET: api/SuitesApi/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSuite([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var suite = await _context.Suite.FindAsync(id);

            if (suite == null)
            {
                return NotFound();
            }

            return Ok(suite);
        }

        // PUT: api/SuitesApi/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSuite([FromRoute] int id, [FromBody] Suite suite)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != suite.SuiteId)
            {
                return BadRequest();
            }

            _context.Entry(suite).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SuiteExists(id))
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

        // POST: api/SuitesApi
        [HttpPost]
        public async Task<IActionResult> PostSuite([FromBody] Suite suite)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Suite.Add(suite);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSuite", new { id = suite.SuiteId }, suite);
        }

        // DELETE: api/SuitesApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSuite([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var suite = await _context.Suite.FindAsync(id);
            if (suite == null)
            {
                return NotFound();
            }

            _context.Suite.Remove(suite);
            await _context.SaveChangesAsync();

            return Ok(suite);
        }

        private bool SuiteExists(int id)
        {
            return _context.Suite.Any(e => e.SuiteId == id);
        }
    }
}