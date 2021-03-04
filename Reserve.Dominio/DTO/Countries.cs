using System;
using System.Collections.Generic;
using System.Text;

namespace Reserve.Dominio.DTO
{
    public class Countries
    {
        public string ID { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public int TotalConfirmed { get; set; }
        public int TotalRecovered { get; set; }

        public int TotalAtivos { get {

                return TotalConfirmed - TotalRecovered;
            
            } }

    }
}
