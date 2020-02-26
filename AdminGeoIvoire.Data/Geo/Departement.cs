using System.Collections.ObjectModel;

namespace AdminGeoIvoire.Data.Geo
{
    public class Departement : EntiteGeo
    {
        public int RegionID { get; set; }
        public Region Region { get; set; }

        public virtual Collection<SousPrefecture> SousPrefectures { get; set; }
    }
}