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
    public class PodrucjeController : ControllerBase
    {
        public PticeContext Context { get; set; }
        public PodrucjeController(PticeContext context)
        {
            Context = context;
        }

        [HttpGet]
        [Route("PreuzmiPodrucja")]
        public async Task<ActionResult> PreuzmiPodrucja()
        {
            return Ok(await Context.Podrucja.Include(p => p.Vidjanja)
                                            .Select(p => new 
                                            {
                                                PodrucjeID = p.ID,
                                                PodrucjeNaziv = p.Naziv,
                                                BrojVidjanja = p.Vidjanja
                                                    .Count(q => q.Podrucje.ID==1 && q.Ptica.ID==40)
                                            })
                                            .ToListAsync());
        }

        
    }
}