using System.Diagnostics.Metrics;

namespace CleanArch.Domain.Entities
{
    /// <summary>
    /// Filmes
    /// </summary>
    public class Movie
    {
        public Movie(int id, string name, string genre, string country, string released)
        {
            Id = id;
            Name = name;
            Genre = genre;
            Country = country;
            Released = released;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Country { get; set; }
        public string Released { get; set; }
  }
}