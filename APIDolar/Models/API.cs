using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIDolar.Models
{
    public static class API
    {
        public static async Task<List<Casas2>> ObtenerCasas()
        {
            string apiUrl = "https://www.dolarsi.com/api/api.php?type=valoresprincipales";

            List<Casas2>? casaList = new List<Casas2>();


            HttpClient httpClient = new HttpClient();
            HttpResponseMessage respuesta = await httpClient.GetAsync(apiUrl);

            if (respuesta.IsSuccessStatusCode)
            {
                string json = await respuesta.Content.ReadAsStringAsync();

                casaList = JsonConvert.DeserializeObject<List<Casas2>>(json);
            }



            return casaList;
        }

    }
}


