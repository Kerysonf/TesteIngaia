using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TesteIngaia.Models
{
    public class WeatherModel
    {
        public CoordenadasModel coord { get; set; }
        public List<CondicoesModel> weather { get; set; }
        public string Base { get; set; }
        public TemperaturaModel main { get; set; }
        public VentoModel wind{ get; set; }
        public NuvemModel clouds { get; set; }
        public int dt { get; set; }
        public SysModel sys { get; set; }
        public int timezone { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }
    }
}