using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private static List<Filme> filmes = new List<Filme>();

        [HttpPost]
        public void AdicionarFilme([FromBody]Filme filme)
        {
            if (!string.IsNullOrEmpty(filme.Titulo) &&
                filme.Titulo.Length <= 500 &&
                !string.IsNullOrEmpty(filme.Genero) &&
                filme.Duracao >= 70)
            {
                filmes.Add(filme);
                Console.WriteLine(filme.Titulo);
                Console.WriteLine(filme.Genero);
                Console.WriteLine(filme.Duracao);
            }
        }
    }
}
