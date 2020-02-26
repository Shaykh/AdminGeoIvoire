using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using AdminGeoIvoire.Data;
using AdminGeoIvoire.Data.Dbo;

namespace AdminGeoIvoire.DataLayerEF
{
    public static class GeoDbContextExtensions
    {
        public static void Add<TEntity>(this GeoDbContext dbContext, TEntity entity, IUserInfo userInfo) where TEntity : class, IEntite
        {
            if  (string.IsNullOrWhiteSpace(entity.Createur))
            {
                entity.Createur = userInfo.NomUtilisateur;
            }
            if (!entity.DateCreation.HasValue) 
            {
                entity.DateCreation = DateTime.Now;
            }

            dbContext.Set<TEntity>().Add(entity);
        }

        public static void Update<TEntity>(this GeoDbContext dbContext, TEntity entity, IUserInfo userInfo) where TEntity : class, IEntite
        {
            if  (string.IsNullOrWhiteSpace(entity.DernierModificateur))
            {
                entity.DernierModificateur = userInfo.NomUtilisateur;
            }
            if (!entity.DateDerniereModification.HasValue) 
            {
                entity.DateDerniereModification = DateTime.Now;
            }

            dbContext.Set<TEntity>().Update(entity);
        }

        public static void Remove<TEntity>(this GeoDbContext dbContext, TEntity entity, IUserInfo userInfo) where TEntity : class, IEntite
        {
            if  (string.IsNullOrWhiteSpace(entity.DernierModificateur))
            {
                entity.DernierModificateur = userInfo.NomUtilisateur;
            }
            if (!entity.DateDerniereModification.HasValue) 
            {
                entity.DateDerniereModification = DateTime.Now;
            }

            entity.Actif = false;

            dbContext.Set<TEntity>().Update(entity);
        }

        public static IEnumerable<LogChange> GetChanges(this GeoDbContext dbContext, IUserInfo userInfo)
        {
            foreach (var entry in dbContext.ChangeTracker.Entries())
            {
                if (entry.State != EntityState.Modified)
                    continue;

                var entityType = entry.Entity.GetType();

                foreach (var property in entityType.GetTypeInfo().DeclaredProperties)
                {

                    var originalValue = entry.Property(property.Name).OriginalValue;
                    var currentValue = entry.Property(property.Name).CurrentValue;

                    if (string.Concat(originalValue) == string.Concat(currentValue))
                        continue;

                    // todo: improve the way to retrieve primary key value from entity instance

                    var key = entry.Entity.GetType().GetProperties().First().GetValue(entry.Entity, null).ToString();

                    yield return new LogChange
                    {
                        NomDeClasse = entityType.Name,
                        NomDePropriete = property.Name,
                        Cle = key,
                        ValeurInitiale = originalValue == null ? string.Empty : originalValue.ToString(),
                        ValeurCourante = currentValue == null ? string.Empty : currentValue.ToString(),
                        NomUtilisateur = userInfo.NomUtilisateur,
                        DateChangement = DateTime.Now
                    };
                }
            } 
        }
    }
}