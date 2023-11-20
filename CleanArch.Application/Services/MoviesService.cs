using CleanArch.Application.Interfaces;
using CleanArch.Domain.Entities;
using CleanArch.Infra.Interfaces;

namespace CleanArch.Application
{
  public class MoviesService : IMoviesService
  {
        private readonly IMoviesRepository movieRepository;
        public MoviesService(IMoviesRepository movieRepository)
        {
            this.movieRepository = movieRepository;
        }

        public List<Movie> GetAll()
        {
            return this.movieRepository.GetAll();
        }
  }
}