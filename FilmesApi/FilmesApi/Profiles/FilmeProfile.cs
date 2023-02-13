using FilmesApi.Data.Dtos;
using FilmesApi.Models;
using AutoMapper;

namespace FilmesApi.Profiles
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile()
        {
            CreateMap<CreatFilmeDto, Filme>();
        }
    }
}
