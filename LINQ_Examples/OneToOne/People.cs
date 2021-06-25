namespace FirstTask.OneToOne
{
    public class People
    {
        public int Id { get; set; }
        public bool SdalRolika { get; set; }
        public int PassportId { get; set; }
        public Passport Passport { get; set; }
    }
}
