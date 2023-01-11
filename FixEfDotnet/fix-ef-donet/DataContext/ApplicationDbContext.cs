using Microsoft.EntityFrameworkCore;

namespace fix_ef_donet.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        // injection
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<CategoryEntity> CategoryEntities => Set<CategoryEntity>();

        public DbSet<HeroEntity> HeroEntities => Set<HeroEntity>();

        public DbSet<AssetEntity> AssetEntities => Set<AssetEntity>();

        public DbSet<AbsenEntity> AbsenEntities => Set<AbsenEntity>();

        public DbSet<NinjaEntity> NinjaEntities => Set<NinjaEntity>();

    }


}

