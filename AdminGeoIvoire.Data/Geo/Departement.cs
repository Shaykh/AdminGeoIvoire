using System.Collections.ObjectModel;
using System;

namespace AdminGeoIvoire.Data.Geo
{
    public class Departement : EntiteGeo
    {
        public Departement()
        {
        }
        public Departement(int? id) : base(id)
        {
        }

        public int RegionID { get; set; }
        public Region Region { get; set; }

        public virtual Collection<SousPrefecture> SousPrefectures { get; set; }
    }
}