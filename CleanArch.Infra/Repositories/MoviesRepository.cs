using CleanArch.Domain.Entities;
using CleanArch.Infra.Interfaces;

namespace CleanArch.Infra.Repositories
{
    public class MoviesRepository : IMoviesRepository
    {
        public static List<Movie> listMovies = new List<Movie>()
        {
           new Movie(1, "Uncharted: Fora do Mapa", "Ação", "EUA", "2022-02-19"),
           new Movie(2, "Missão: Impossível", "Ação", "EUA", "2023-07-13"),
           new Movie(3, "Uma Prova de Amor", "Drama", "EUA", "2009-09-11"),
        };
        public List<Movie> GetAll()
        {
            return listMovies;
        }
    }
}