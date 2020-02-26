using System;

namespace AdminGeoIvoire.Data.Dbo
{
    public class LogEvenement
    {
        public LogEvenement()
        {
        }

        public int? ID { get; set; }

        public int? TypeEvenement { get; set; }

        public string Cle { get; set; }

        public string Message { get; set; }

        public DateTime? DateLog { get; set; }
    }
}