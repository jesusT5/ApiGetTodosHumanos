using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ApiGetTodosHumanos;
using ApiGetTodosHumanos.Data;

namespace ApiGetTodosHumanos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HumanosController : ControllerBase
    {
        private readonly ApiGetTodosHumanosContext _context;

        public HumanosController(ApiGetTodosHumanosContext context)
        {
            _context = context;
        }

        // GET: Humanos
        [HttpGet("GetHumanos")]
        public async Task<IActionResult> GetHumanos()
        {
            return Ok(await _context.Humano.ToListAsync());
        }
    }
}
