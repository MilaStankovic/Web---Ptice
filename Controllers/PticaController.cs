using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;

namespace Web___Ptice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PticaController : ControllerBase
    {
        public PticeContext Context { get; set; }
        public PticaController(PticeContext context)
        {
            Context = context;
        }

        
    }
}
