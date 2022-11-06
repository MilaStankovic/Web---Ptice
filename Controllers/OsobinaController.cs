using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Models;

namespace Web___Ptice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OsobinaController : ControllerBase
    {
        public PticeContext Context { get; set; }
        public OsobinaController(PticeContext context)
        {
            Context = context;
        }

        [HttpGet]
        [Route("PreuzmiOsobine")]
        public async Task<ActionResult> PreuzmiOsobine()
        {
            var podaci=await Context.Osobine.ToListAsync();

            var grupisano=podaci.GroupBy(p=>p.Naziv);

            return Ok(grupisano.ToDictionary(p => p.Key, q => q.Select(r => r.Vrednost).ToList()));

            /*return Ok(await Context.Osobine.Select(p => new
            {
                p.ID,
                p.Naziv,
                p.Vrednost
            }).ToListAsync());*/
        }

        
    }
}