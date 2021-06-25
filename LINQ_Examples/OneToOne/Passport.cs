namespace FirstTask.OneToOne
{
    public class Passport
    {
        public int Id { get; set; }
        public string PeopleName { get; set; }
        public int Age { get; set; }
        public int PeopleId { get; set; }
        public People People { get; set; }
    }
}
