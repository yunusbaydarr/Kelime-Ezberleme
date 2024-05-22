using KelimeEzberlemeSistemi.Context;
using KelimeEzberlemeSistemi.Model;

namespace KelimeEzberlemeSistemi.Manager
{

    public class RaporManager
    {
        private readonly EfContext context;

        public RaporManager()
        {
            context = new EfContext();
        }

        public string RaporuGetir()
        {
            context.DogruCevaps.Where(t => t.UserId == StaticVeriables.userId).OrderBy(t => t.Konu).ToList();
            var dogruCevaplar = context.DogruCevaps
            .Where(t => t.UserId == StaticVeriables.userId)
            .GroupBy(t => t.Konu)
            .OrderBy(g => g.Key)
            .Select(g => $"{g.Key}: {g.Count()} soru bildiniz.")
            .ToList();

            var sonucString = string.Join(Environment.NewLine, dogruCevaplar);

            return sonucString;

        }
    }
}
