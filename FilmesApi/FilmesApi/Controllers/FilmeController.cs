using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private static List<Filme> filmes = new List<Filme>();

        private static int Id = 0;

        [HttpPost]
        public IActionResult AdicionarFilme([FromBody] Filme filme)
        {
            filme.Id = Id++;
            filmes.Add(filme);
            return CreatedAtAction(nameof(RecuperaFilmePorId), new { Id = filme.Id }, filme);
        }

        [HttpGet]
        public IEnumerable<Filme> RecuperaFilmes([FromQuery] int skip = 0, [FromQuery] int take = 50)
        {
            return filmes.Skip(skip).Take(take);
        }

        [HttpGet("{Id}")]
        public IActionResult RecuperaFilmePorId(int Id)
        {
           var filme = filmes.FirstOrDefault(filme => filme.Id == Id);
            if (filme == null) return NotFound();

            return Ok(filme);
        }
    }
}
