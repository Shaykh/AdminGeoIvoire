using System.Collections.ObjectModel;

namespace AdminGeoIvoire.Data.Geo
{
    public class Region : EntiteGeo
    {
        public bool EstDistrict { get; set; }

        public virtual Collection<Departement> Departements { get; set; }
    }
}