using CleanArch.Application.Interfaces;
using CleanArch.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.Api.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class MoviesController : ControllerBase
  {
    private readonly ILogger<MoviesController> _logger;
    private readonly IMoviesService _moviesService;

    public MoviesController(ILogger<MoviesController> logger, IMoviesService moviesService)
    {
        _logger = logger;
        _moviesService = moviesService;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    [HttpGet(Name = "movies")]
    public ActionResult<IList<Movie>> Get()
    {
      return Ok(_moviesService.GetAll());
    }
  }
}