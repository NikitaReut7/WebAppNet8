using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Context;
using WebApp.Models;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EntitiesController : ControllerBase
    {
        private readonly IDataContext _context;

        public EntitiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("base")] // GET: api/entities/base
        public async Task<IActionResult> GetBaseEntities()
        {
            var a = await _context.Set<BaseEntity>().ToArrayAsync();
            return Ok(a);
        }

        [HttpGet("a")] // GET: api/entities/a
        public async Task<IActionResult> GetDerivedEntitiesA()
        {
            var a = await _context.Set<DerivedEntityA>().ToArrayAsync();

            return Ok(a);
        }

        [HttpGet("b")] // GET: api/entities/b
        public async Task<IActionResult> GetDerivedEntitiesB()
        {
            var a = await _context.Set<DerivedEntityB>().ToArrayAsync().ConfigureAwait(false);

            return Ok(a);
        }

        [HttpGet("C")] // GET: api/entities/c
        public async Task<IActionResult> GetDerivedEntitiesC()
        {
            var a = await _context.Set<DerivedEntityC>().ToArrayAsync().ConfigureAwait(false);

            return Ok(a);
        }
    }
}
