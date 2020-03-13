using System.Collections.Generic;

namespace Api.Models
{
    public class Director
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Movie> Movies { get; set; }
    }
}