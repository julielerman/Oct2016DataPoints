using Microsoft.EntityFrameworkCore;

namespace EFCoreCoreCLR {
    public class SamuraiContext : DbContext {
        public DbSet<Samurai> Samurais { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
                if (optionsBuilder.IsConfigured == false) {
                    optionsBuilder.UseNpgsql
                      ("User ID=julie;Password=12345;Host=localhost;Port=5432;Database=weatherdataRTM;Pooling=true;");
                }

                base.OnConfiguring(optionsBuilder);
            }

        public SamuraiContext(DbContextOptions<SamuraiContext> options)
         : base(options) { }
         public SamuraiContext ()
         {
           
         }
    }
}