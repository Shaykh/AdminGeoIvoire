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
        #region Region
        public static async Task<Region> GetRegionAsync(this GeoDbContext dbContext, Region region)
            => await dbContext.Regions.FirstOrDefaultAsync(item => item.ID == region.ID);

        public static Region GetRegionByLibelle(this GeoDbContext dbContext, string libelle)
            => dbContext.Regions.FirstOrDefault(item => item.Libelle.ToUpper() == libelle.ToUpper());

        public static IQueryable<Region> GetRegions(this GeoDbContext dbContext, int? regionID = null)
        {
            var requete = dbContext.Regions.AsQueryable();

            if (regionID.HasValue)
            {
                requete = requete.Where(r => r.ID = regionID);
            }

            return requete;
        }
        #endregion

        #region Departement
        public static async Task<Departement> GetDepartementAsync(this GeoDbContext dbContext, Departement departement)
            => await dbContext.Departements.FirstOrDefaultAsync(item => item.ID == departement.ID);

        public static Departement GetDepartementByLibelle(this GeoDbContext dbContext, string libelle)
            => dbContext.Departements.FirstOrDefault(item => item.Libelle.ToUpper() == libelle.ToUpper());
            
        public static IQueryable<Departement> GetDepartements(this GeoDbContext dbContext, int? departementID = null)
        {
            var requete = dbContext.Departements.AsQueryable();

            if (departementID.HasValue)
            {
                requete = requete.Where(r => r.ID = departementID);
            }

            return requete;
        }
        #endregion

        #region SousPrefecture
        public static async Task<SousPrefecture> GetSousPrefectureAsync(this GeoDbContext dbContext, SousPrefecture sousPrefecture)
            => await dbContext.SousPrefectures.FirstOrDefaultAsync(item => item.ID == sousPrefecture.ID);

        public static SousPrefecture GetSousPrefectureByLibelle(this GeoDbContext dbContext, string libelle)
            => dbContext.SousPrefectures.FirstOrDefault(item => item.Libelle.ToUpper() == libelle.ToUpper());
             
        public static IQueryable<SousPrefecture> GetSousPrefectures(this GeoDbContext dbContext, int? sousPrefectureID = null)
        {
            var requete = dbContext.SousPrefectures.AsQueryable();

            if (sousPrefectureID.HasValue)
            {
                requete = requete.Where(r => r.ID = sousPrefectureID);
            }

            return requete;
        }
        #endregion

        #region Village
        public static async Task<Village> GetVillagesync(this GeoDbContext dbContext, Village village)
            => await dbContext.Villages.FirstOrDefaultAsync(item => item.ID == village.ID);

        public static Village GetVillageByLibelle(this GeoDbContext dbContext, string libelle)
            => dbContext.Villages.FirstOrDefault(item => item.Libelle.ToUpper() == libelle.ToUpper());

        public static Village GetVillageByLibelleEtDepartement(this GeoDbContext dbContext, string libelleVillage, string libelleDepartement)
            => dbContext.Villages.FirstOrDefault(item => item.Libelle.ToUpper() == libelleVillage.ToUpper() 
                && item.SousPrefecture.Departement.Libelle.ToUpper() == libelleDepartement.ToUpper());
             
        public static IQueryable<Village> GetVillages(this GeoDbContext dbContext, int? villageID = null)
        {
            var requete = dbContext.Villages.AsQueryable();

            if (villageID.HasValue)
            {
                requete = requete.Where(r => r.ID = villageID);
            }

            return requete;
        }
        #endregion
    }
}