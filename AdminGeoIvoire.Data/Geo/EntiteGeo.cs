using AdminGeoIvoire.Data;

namespace AdminGeoIvoire.Data.Geo
{
    public class EntiteGeo : Entite
    {
        public EntiteGeo()
        {
        }

        public EntiteGeo(int? id)
        {
            ID = id;
        }
        public int? ID { get; set; }

        public string Libelle { get; set; }

        public byte[] Timestamp { get; set; }
    }
}