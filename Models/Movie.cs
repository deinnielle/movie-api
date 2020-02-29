namespace Api.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; } = "Texas, Paris";
        public double Rating { get; set; } = 8.0;
        public string Genre { get; set; } = "Drama";
    }
}