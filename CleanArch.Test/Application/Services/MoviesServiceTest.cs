using System.Collections.Generic;
using CleanArch.Application;
using CleanArch.Domain.Entities;
using CleanArch.Infra.Interfaces;
using Moq;

namespace CleanArch.Test.Application.Services
{
    public class MoviesRepositoryTest
    {
      [Fact]
      public void GetAll_ShouldReturnMovies()
      {
        // Arrange
        var mockRepository = new Mock<IMoviesRepository>();
        var moviesService = new MoviesService(mockRepository.Object);

        var expectedMovies = new List<Movie>
        {
            new Movie(1, "Movie 1", "Ação", "EUA", "2023-05-02" ),
            new Movie(2, "Movie 2", "Drama", "EUA", "2023-05-02" ),
        };

        mockRepository.Setup(repo => repo.GetAll()).Returns(expectedMovies);

        // Act
        var result = moviesService.GetAll();

        // Assert
        Assert.Equal(expectedMovies, result);
      }
    }
}