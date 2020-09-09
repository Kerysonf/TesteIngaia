using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using TesteIngaia.Models;

namespace TesteIngaia.BLL
{
    public class MusicasBLL
    {
        public List<string> GetMusicasByCidade(string cidade) 
        {
            var temp = GetTemp(cidade);
            var lstMusicas = GetMusicas(temp);
            return lstMusicas;
        }
        private List<string> GetMusicas(decimal temp) 
        {
            var lstRetorno = new List<string>();
            if (temp > 25)
            {
                lstRetorno.Add("Uptown Funk - Bruno Mars");
                lstRetorno.Add("Shallow - Lady Gaga");
                lstRetorno.Add("Thank you, Next - Ariana Grande");
            }
            else if (temp >= 10 && temp <= 25)
            {
                lstRetorno.Add("Enter sandman - Metalica");
                lstRetorno.Add("Seven Nation Army - White Stripes");
                lstRetorno.Add("Eleanor Rigby - The Beatles");
                lstRetorno.Add("Hotel California - The Eagles");
            }
            else if (temp < 10)
            {
                lstRetorno.Add("Il barbiere di Siviglia - Giochino Rossini");
                lstRetorno.Add("Symphony Nº5 (Destiny) - Ludwig Van Beethoven");
                lstRetorno.Add("Le quattro stagioni (La Primavera) - Antonio Vivaldi");
            }
            return lstRetorno;
        }
        private decimal GetTemp(string cidade) 
        {

            var model = new WeatherModel();
            var url = $"http://api.openweathermap.org/data/2.5/weather?q={cidade}&appid=b72ff52cbd4b67a4d6514051b42aabb5";
            var request = WebRequest.Create(url);
            request.Method = "GET";
            using (var response = request.GetResponse())
            {
                var dataStream = response.GetResponseStream();
                var reader = new StreamReader(dataStream);
                var objReturn = reader.ReadToEnd();
                model = JsonConvert.DeserializeObject<WeatherModel>(objReturn.ToString());
            }
            var temp = model.main.temp - 273.15M;
            return temp;
        }
    }
}