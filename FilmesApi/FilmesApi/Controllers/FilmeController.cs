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
        public void AdicionarFilme([FromBody] Filme filme)
        {
            filme.Id = Id++;
            filmes.Add(filme);
            Console.WriteLine(filme.Titulo);
            Console.WriteLine(filme.Genero);
            Console.WriteLine(filme.Duracao);
        }

        [HttpGet]
        public IEnumerable<Filme> RecuperaFilmes()
        {
            return filmes;
        }

        [HttpGet("{Id}")]
        public Filme? RecuperaFilmePorId(int Id)
        {
            return filmes.FirstOrDefault(filme => filme.Id == Id);
        }
    }
}
