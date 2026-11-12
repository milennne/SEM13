using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APIDemo2026AB.Models;

[Route("api/[controller]")]
[ApiController]
public class InstructorsController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    public InstructorsController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/Instructor
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Instructor>>> GetInstructor()
    {
        return await _context.Instructors.ToListAsync();
    }

    // GET: api/Instructor/5
    [HttpGet("{instructorid}")]
    public async Task<ActionResult<Instructor>> GetInstructor(int instructorid)
    {
        var instructor = await _context.Instructors.FindAsync(instructorid);

        if (instructor == null)
        {
            return NotFound();
        }

        return instructor;
    }

    // PUT: api/Instructor/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{instructorid}")]
    public async Task<IActionResult> PutInstructor(int? instructorid, Instructor instructor)
    {
        if (instructorid != instructor.InstructorId)
        {
            return BadRequest();
        }

        _context.Entry(instructor).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!InstructorExists(instructorid))
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

    // POST: api/Instructor
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Instructor>> PostInstructor(Instructor instructor)
    {
        _context.Instructors.Add(instructor);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetInstructor", new { instructorid = instructor.InstructorId }, instructor);
    }

    // DELETE: api/Instructor/5
    [HttpDelete("{instructorid}")]
    public async Task<IActionResult> DeleteInstructor(int? instructorid)
    {
        var instructor = await _context.Instructors.FindAsync(instructorid);
        if (instructor == null)
        {
            return NotFound();
        }

        _context.Instructors.Remove(instructor);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool InstructorExists(int? instructorid)
    {
        return _context.Instructors.Any(e => e.InstructorId == instructorid);
    }
}
