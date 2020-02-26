using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AdminGeoIvoire.Data;
using AdminGeoIvoire.Data.Geo;

namespace AdminGeoIvoire.DataLayerEF
{
    public static class GeoDbContextQueries
    {
        public static async Task<Region> GetRegionAsync(this GeoDbContext dbContext, Region region)
            => await dbContext.Regions.FirstOrDefaultAsync(item => item.ID == region.ID);

        public static Region GetRegionByLibelle(this GeoDbContext dbContext, string libelle)
            => dbContext.Regions.FirstOrDefault(item => item.Libelle.ToUpper() == libelle.ToUpper());

        public static async Task<Departement> GetDepartementAsync(this GeoDbContext dbContext, Departement departement)
            => await dbContext.Departements.FirstOrDefaultAsync(item => item.ID == departement.ID);

        public static async Task<SousPrefecture> GetSousPrefectureAsync(this GeoDbContext dbContext, SousPrefecture sousPrefecture)
            => await dbContext.SousPrefectures.FirstOrDefaultAsync(item => item.ID == sousPrefecture.ID);

        public static async Task<Village> GetVillagesync(this GeoDbContext dbContext, Village village)
            => await dbContext.Villages.FirstOrDefaultAsync(item => item.ID == village.ID);

    }
}