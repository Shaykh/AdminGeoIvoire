namespace AdminGeoIvoire.Data.Geo
{
    public class Village : EntiteGeo
    {
        public Village()
        {
        }
        public Village(int? id) : base(id)
        {
        }

        public int SousPrefectureID { get; set; }
        public SousPrefecture SousPrefecture { get; set; }
    }
}