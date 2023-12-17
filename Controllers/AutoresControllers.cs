using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationIDL2.Controllers.Entidades;

namespace WebApplicationIDL2.Controllers
{
    [ApiController]

    [Route("api/autores")]
        
    public class AutoresControllers : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public AutoresControllers(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]

        public async Task<List<Autor>> Get() 
        {
            return await context.Autores.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult> Post(Autor autor)
        {
            context.Add(autor);
            await context.SaveChangesAsync();
            return Ok();
        }
    }

}
