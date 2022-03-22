using System.ComponentModel.DataAnnotations;

 namespace Best.Videogames.Models
{
    public class VideoGame
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; }
        public decimal Price { get; set; }
        public int Number { get; set; }
    }
}
