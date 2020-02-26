using System.Collections.ObjectModel;

namespace AdminGeoIvoire.Data.Geo
{
    public class Region : EntiteGeo
    {
        public virtual Collection<Departement> Departements { get; set; }
    }
}