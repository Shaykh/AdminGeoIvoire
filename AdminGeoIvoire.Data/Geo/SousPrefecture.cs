using System.Collections.ObjectModel;

namespace AdminGeoIvoire.Data.Geo
{
    public class SousPrefecture : EntiteGeo
    {
        public SousPrefecture()
        {
        }
        public SousPrefecture(int? id) : base(id)
        {
        }
        
        public bool EstCommune { get; set; }

        public int DepartementID { get; set; }
        public Departement Departement { get; set; }

        public virtual Collection<Village> Villages { get; set; }
    }
}