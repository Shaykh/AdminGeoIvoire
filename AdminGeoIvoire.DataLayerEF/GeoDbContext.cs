using Microsoft.EntityFrameworkCore;
using AdminGeoIvoire.Data.Dbo;
using AdminGeoIvoire.Data.Geo;

namespace AdminGeoIvoire.DataLayerEF
{
    public class GeoDbContext : DbContext
    {
        public GeoDbContext(DbContextOptions<GeoDbContext> options) : base(options)
        {
        }

        public DbSet<LogChange> LogChanges { get; set; }

        public DbSet<LogEvenement> LogEvenements { get; set; }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Departement> Departements { get; set; }

        public DbSet<SousPrefecture> SousPrefectures { get; set; }

        public DbSet<Village> Villages { get; set; }
    }
}