using Api.Context;
using Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtletasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AtletasController(AppDbContext context) { 
            _context = context;
        }

        // GET: api/<AtletasController>
        [HttpGet]
        public ActionResult<IEnumerable<Atleta>> GetAtendentes()
        {
            try
            {
                var Atletas = _context.atletas.Take(10).ToList();

                if (Atletas is null)
                {
                    return NotFound("Não exitem Atletas?");
                }
                else{
                    return Atletas.ToList();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    $"Ocorreu um erro ao evocar a ação!!! {ex}");
            }
        }

        // GET api/<AtletasController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AtletasController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AtletasController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AtletasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
