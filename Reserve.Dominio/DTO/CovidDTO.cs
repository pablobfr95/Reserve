using System;
using System.Collections.Generic;
using System.Text;

namespace Reserve.Dominio.DTO
{
    public class CovidDTO
    {
        public string ID { get; set; }
        public string Message { get; set; }
        public IList<Countries> Countries { get; set; }
        public DateTime Date { get; set; }
    }
}
