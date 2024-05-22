using KelimeEzberlemeSistemi.Context;
using KelimeEzberlemeSistemi.Model;

namespace KelimeEzberlemeSistemi.Manager
{
    public class ExamManager
    {
        private readonly EfContext context;
        public ExamManager()
        {
            context = new EfContext();
        }

        public List<Word> KelimeleriGetir()
        {
            //Kullanıcının cevabı bildiği tüm soruları tarihe göre sıralayıp en son tarihe göre kelimeyi al.
            var sonSoruCevapListesi = context.soruCevaps
            .Where(sc => sc.UserId == StaticVeriables.userId) // Belirli kullanıcıya ait soru cevaplarını filtrele
            .GroupBy(sc => sc.WordId) // Kelime ID'ye göre grupla
            .Select(g => g.OrderByDescending(sc => sc.Tarih).First()) // Her gruptaki en son tarihli kaydı seç
            .ToList(); // Sonuç listesini al

            List<int> soruCevapIds = new List<int>();

            var uniqueIds = context.soruCevaps.Select(sc => sc.WordId).Distinct().ToList();
            var remainingWords = context.Words.Where(w => !uniqueIds.Contains(w.Id)).ToList().Take(StaticVeriables.soruSayisi);

            foreach (var soruCevap in sonSoruCevapListesi)
            {
                switch (soruCevap.SonrakiTarih)
                {
                    case "1 gün sonra":
                        if (StaticVeriables.guncelTarih >= soruCevap.Tarih.AddDays(1))
                        {
                            // 1 gün sonra tarihine göre
                            soruCevapIds.Add(soruCevap.WordId);
                        }
                        break;
                    case "1 hafta sonra":
                        if (StaticVeriables.guncelTarih >= soruCevap.Tarih.AddDays(7))
                        {
                            // 1 hafta sonra tarihine göre 
                            soruCevapIds.Add(soruCevap.WordId);

                        }
                        break;
                    case "1 ay sonra":
                        if (StaticVeriables.guncelTarih >= soruCevap.Tarih.AddMonths(1))
                        {
                            // 1 ay sonra tarihine göre
                            soruCevapIds.Add(soruCevap.WordId);

                        }
                        break;
                    case "3 ay sonra":
                        if (StaticVeriables.guncelTarih >= soruCevap.Tarih.AddMonths(3))
                        {
                            // 3 ay sonra tarihine göre
                            soruCevapIds.Add(soruCevap.WordId);

                        }
                        break;
                    case "6 ay sonra":
                        if (StaticVeriables.guncelTarih >= soruCevap.Tarih.AddMonths(6))
                        {
                            // 6 ay sonra tarihine göre
                            soruCevapIds.Add(soruCevap.WordId);

                        }
                        break;
                    case "1 yıl sonra":
                        if (StaticVeriables.guncelTarih >= soruCevap.Tarih.AddYears(1))
                        {
                            // 1 yıl sonra tarihine göre
                            soruCevapIds.Add(soruCevap.WordId);

                        }
                        break;
                    default:
                        // Tanımsız bir durum olduğunda
                        break;
                }
            }


            var wordsWithSoruCevapIds = context.Words.Where(w => soruCevapIds.Contains(w.Id)).ToList();
            var words = remainingWords.Concat(wordsWithSoruCevapIds);


            //Kullanıcının 6 denemede doğru cevaplayıp artık sınava gelmesini istemediğimiz j
            var dogruSorular = context.DogruCevaps.Where(t => t.UserId == StaticVeriables.userId).Select(t => t.WordId).ToList();

            var sonListe = words.Where(t => !dogruSorular.Contains(t.Id)).ToList();

            return sonListe;
        }

        public void SoruCevaplariniKayitEt(int wordId, string cevap)
        {
            var ilkCevap = "1 gün sonra";

            var word = context.Words.FirstOrDefault(t => t.Id == wordId);
            var controlDogruCevap = false;
            if (word.TurkceKarsiligi == cevap)
            {
                controlDogruCevap = true;
            }

            if (controlDogruCevap)
            {

                var ilkCevapVarmi = context.soruCevaps
                .Where(t => t.UserId == StaticVeriables.userId && t.WordId == wordId)
                .OrderByDescending(t => t.Tarih) // Tarihe göre azalan şekilde sırala (en son tarih en üstte olacak)
                .FirstOrDefault(); // En son cevabı al

                if (ilkCevapVarmi != null)
                {
                    if (ilkCevapVarmi.SonrakiTarih != "6 ay sonra")
                    {
                        if (ilkCevapVarmi.SonrakiTarih == "1 gün sonra")
                        {
                            ilkCevap = "1 hafta sonra";
                        }

                        if (ilkCevapVarmi.SonrakiTarih == "1 hafta sonra")
                        {
                            ilkCevap = "1 ay sonra";
                        }

                        if (ilkCevapVarmi.SonrakiTarih == "1 ay sonra")
                        {
                            ilkCevap = "3 ay sonra";
                        }
                        if (ilkCevapVarmi.SonrakiTarih == "3 ay sonra")
                        {
                            ilkCevap = "6 ay sonra";
                        }
                        if (ilkCevapVarmi.SonrakiTarih == "6 ay sonra")
                        {
                            ilkCevap = "1 yıl sonra";
                        }
                        SoruCevap kayit = new SoruCevap()
                        {
                            SonrakiTarih = ilkCevap,
                            Tarih = StaticVeriables.guncelTarih,
                            UserId = StaticVeriables.userId,
                            WordId = wordId,
                        };

                        context.soruCevaps.Add(kayit);
                        context.SaveChanges();
                    }
                    else
                    {
                        DogruCevap dogruCevap = new DogruCevap()
                        {
                            UserId = StaticVeriables.userId,
                            WordId = wordId,
                            Konu = word.Konu
                        };
                        context.DogruCevaps.Add(dogruCevap);
                        context.SaveChanges();

                        var tumCevaplar = context.soruCevaps.Where(t => t.UserId == StaticVeriables.userId && t.WordId == wordId).ToList();
                        context.soruCevaps.RemoveRange(tumCevaplar);
                        context.SaveChanges();
                    }

                }
                else
                {

                    SoruCevap kayit = new SoruCevap()
                    {
                        SonrakiTarih = ilkCevap,
                        Tarih = DateTime.Now,
                        UserId = StaticVeriables.userId,
                        WordId = wordId,

                    };

                    context.soruCevaps.Add(kayit);
                    context.SaveChanges();

                }
            }

            else
            {
                var tumCevaplar = context.soruCevaps.Where(t => t.UserId == StaticVeriables.userId && t.WordId == wordId).ToList();
                context.soruCevaps.RemoveRange(tumCevaplar);
                context.SaveChanges();
            }

        }

    }
}
