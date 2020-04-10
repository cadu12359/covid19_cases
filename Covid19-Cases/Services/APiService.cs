using Covid19_Cases.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Covid19_Cases.Services
{
    public class APiService
    {
        public static RequestItem GetData(string country)
        {
            var URL = "https://coronavirus-monitor.p.rapidapi.com/coronavirus/latest_stat_by_country.php";

            try
            {
                HttpClient requisicao = new HttpClient();
                requisicao.DefaultRequestHeaders.Add("x-rapidapi-host", "coronavirus-monitor.p.rapidapi.com");
                requisicao.DefaultRequestHeaders.Add("x-rapidapi-key", "ff135f5670msh23cc75c0b283f47p1f8b84jsn3e3b0731b371");
                requisicao.Timeout = TimeSpan.FromSeconds(30);
                HttpResponseMessage resposta = requisicao.GetAsync(URL + "?country=" + country).GetAwaiter().GetResult();

                var data = resposta.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                RequestItem data_country = JsonConvert.DeserializeObject<RequestItem>(data);

                return data_country;
            }
            catch (TaskCanceledException e)
            {
                throw;
            }
            catch (Exception e)
            {
                throw;
            }

        }



    }
}
