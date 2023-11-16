using Microsoft.AspNetCore.Mvc;

namespace CleanArch.Api.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class MoviesController : ControllerBase
  {
    private readonly ILogger<MoviesController> _logger;

    public MoviesController(ILogger<MoviesController> logger)
    {
      _logger = logger;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    [HttpGet(Name = "movies")]
    public string Get()
    {
      return "Em construção";
    }
  }
}