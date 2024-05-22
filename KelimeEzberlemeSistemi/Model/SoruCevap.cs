namespace KelimeEzberlemeSistemi.Model
{
    public class SoruCevap
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int WordId { get; set; }
        public string SonrakiTarih { get; set; }
        public Word Word { get; set; }
        public User User { get; set; }
        public DateTime Tarih { get; set; }

    }
}
