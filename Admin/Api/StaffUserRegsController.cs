using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Admin.Data;

namespace Admin.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffUserRegsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public StaffUserRegsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/StaffUserRegs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StaffUserReg>>> GetStaffUserRegs()
        {
            return await _context.StaffUserRegs.ToListAsync();
        }

        // GET: api/StaffUserRegs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StaffUserReg>> GetStaffUserReg(int id)
        {
            var staffUserReg = await _context.StaffUserRegs.FindAsync(id);

            if (staffUserReg == null)
            {
                return NotFound();
            }

            return staffUserReg;
        }

        // PUT: api/StaffUserRegs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStaffUserReg(int id, StaffUserReg staffUserReg)
        {
            if (id != staffUserReg.Id)
            {
                return BadRequest();
            }

            _context.Entry(staffUserReg).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StaffUserRegExists(id))
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

        // POST: api/StaffUserRegs
        [HttpPost]
        public async Task<ActionResult<StaffUserReg>> PostStaffUserReg(StaffUserReg staffUserReg)
        {
            _context.StaffUserRegs.Add(staffUserReg);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStaffUserReg", new { id = staffUserReg.Id }, staffUserReg);
        }

        // DELETE: api/StaffUserRegs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<StaffUserReg>> DeleteStaffUserReg(int id)
        {
            var staffUserReg = await _context.StaffUserRegs.FindAsync(id);
            if (staffUserReg == null)
            {
                return NotFound();
            }

            _context.StaffUserRegs.Remove(staffUserReg);
            await _context.SaveChangesAsync();

            return staffUserReg;
        }

        private bool StaffUserRegExists(int id)
        {
            return _context.StaffUserRegs.Any(e => e.Id == id);
        }
    }
}
