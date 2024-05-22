namespace KelimeEzberlemeSistemi.Model
{
    public class Word
    {
        public int Id { get; set; }
        public string Konu { get; set; }
        public string IngilizceKelime { get; set; }
        public string TurkceKarsiligi { get; set; }
        public string CumleIcinde { get; set; }
        public byte[] Resim { get; set; } // Resim verileri için byte dizisi kullanılabilir

    }
}
