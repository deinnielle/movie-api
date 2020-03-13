namespace Api.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Rating { get; set; }
        public string Genre { get; set; }
        public int DirectorId { get; set; }
        public Director Director { get; set; }
    }
}