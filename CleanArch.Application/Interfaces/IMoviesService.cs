using CleanArch.Domain.Entities;

namespace CleanArch.Application.Interfaces
{
    public interface IMoviesService
    {
        List<Movie> GetAll();
    }
}