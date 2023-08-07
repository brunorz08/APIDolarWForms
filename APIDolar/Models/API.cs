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
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = "https://www.dolarsi.com/api/api.php?type=valoresprincipales";

            List<Casas2>? casaList = new List<Casas2>();

            HttpResponseMessage respuesta = await client.GetAsync(apiUrl);

            if (respuesta.IsSuccessStatusCode)
            {
                string json = await respuesta.Content.ReadAsStringAsync();

                casaList = JsonConvert.DeserializeObject<List<Casas2>>(json);
            }



            return casaList;
            }
        }

       public static async Task<Dolares> ObtenerDolares()
        {
            using (HttpClient client = new HttpClient())
            {


                string url = "https://api.bluelytics.com.ar/v2/latest"; // Reemplaza con la URL real de la API que proporciona los datos
                Dolares dolares = new Dolares();

                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();

                     dolares = JsonConvert.DeserializeObject<Dolares>(jsonResponse);

                    
                }
                return dolares;

            }

        }

    }
}


