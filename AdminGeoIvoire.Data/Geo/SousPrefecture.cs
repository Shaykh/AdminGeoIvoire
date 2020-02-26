using System.Collections.ObjectModel;

namespace AdminGeoIvoire.Data.Geo
{
    public class SousPrefecture : EntiteGeo
    {
        public int DepartementID { get; set; }
        public Departement Departement { get; set; }

        public virtual Collection<Village> Villages { get; set; }
    }
}