using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoList.Data;
using ToDoList.Models;

namespace ToDoList.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListsApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ListsApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ListsApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<List>>> GetLists()
        {
            return await _context.Lists.ToListAsync();
        }

        // GET: api/ListsApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<List>> GetLists(int id)
        {
            var list = await _context.Lists.FindAsync(id);

            if (list == null)
            {
                return NotFound();
            }

            return list;
        }

        // PUT: api/ListsApi/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutList(int id, List list)
        {
            if (id != list.Id)
            {
                return BadRequest();
            }

            _context.Entry(list).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ListExists(id))
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

        // POST: api/ListsApi
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<List>> PostList(List list)
        {
            _context.Lists.Add(list);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetList", new { id = list.Id }, list);
        }

        // DELETE: api/ListsApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteList(int id)
        {
            var list = await _context.Lists.FindAsync(id);
            if (list == null)
            {
                return NotFound();
            }

            _context.Lists.Remove(list);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ListExists(int id)
        {
            return _context.Lists.Any(e => e.Id == id);
        }
    }
}
