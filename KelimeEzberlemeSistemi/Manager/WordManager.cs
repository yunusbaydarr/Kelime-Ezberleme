using KelimeEzberlemeSistemi.Context;
using KelimeEzberlemeSistemi.Model;

namespace KelimeEzberlemeSistemi.Manager
{
    public class WordManager
    {
        private readonly EfContext context;

        public WordManager()
        {
            context = new EfContext();
        }

        public bool KelimeEkle(Word word)
        {
            try
            {
                context.Words.Add(word);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;

            }
        }
    }
}
