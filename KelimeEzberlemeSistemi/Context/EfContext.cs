using KelimeEzberlemeSistemi.Model;
using Microsoft.EntityFrameworkCore;

namespace KelimeEzberlemeSistemi.Context
{
    public class EfContext : DbContext
    {
        private const string ConnectionStringName = "Server=DESKTOP-U8CCE5A\\SQLEXPRESS;Database=KelimeEzberleme;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionStringName);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Word> Words { get; set; }
        public DbSet<DogruCevap> DogruCevaps { get; set; }
        public DbSet<SoruCevap> soruCevaps { get; set; }
    }
}
