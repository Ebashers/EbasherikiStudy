namespace EFKinopoisk.Models
{
    public class ActorFilm
    {
        public int Id { get; set; }
        public Actor Actor { get; set; }
        public int ActorId { get; set; }
        public Film Film { get; set; }
        public int FilmId { get; set; }
    }
}
