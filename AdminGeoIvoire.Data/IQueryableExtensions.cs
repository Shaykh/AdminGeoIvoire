using System.Linq;

namespace AdminGeoIvoire.Data
{
    public static class IQueryableExtensions
    {
        public static IQueryable<TModel> Paging<TModel>(this IQueryable<TModel> requete, int pageSize = 0, int pageNumber = 0) where TModel : class
            => pageSize > 0 && pageNumber > 0 ? requete.Skip((pageNumber - 1) * pageSize).Take(pageSize) : requete;
    }
}