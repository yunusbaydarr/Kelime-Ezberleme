﻿namespace KelimeEzberlemeSistemi.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string SifreSorusu { get; set; }
        public string SifreCevabi { get; set; }
    }
}
