using CleanArch.Infra.Repositories;

namespace CleanArch.Test.Infra.Services
{
  public class MoviesRepositoryTest
  {
    [Fact]
    public void GetAll_ShouldReturnMovies()
    {
      // Arrange
      var moviesRepository = new MoviesRepository();

      // Act
      var result = moviesRepository.GetAll();

      // Assert
      Assert.Equal(3, result.Count);
      Assert.Contains(result, movie => movie.Name == "Uncharted: Fora do Mapa");
    }
  }
}