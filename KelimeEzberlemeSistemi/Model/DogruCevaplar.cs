namespace KelimeEzberlemeSistemi.Model
{
    public class DogruCevap
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Konu { get; set; }
        public User User { get; set; }
        public int WordId { get; set; }
        public Word Word { get; set; }
    }
}
