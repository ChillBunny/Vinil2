using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Nodes;
using Vinil2.Servicios;
using Vinil2.Model;

namespace Vinil2.Servicios
{
    public class RickAndMortyService : IRickAndMortyService
    {
        private string urlApi = "https://23.94.148.7:443/api/cliente";
        public async Task<List<PersonajeResponsive.Result>> Obtener()
        {
            var client = new HttpClient();
            var response =  await client.GetAsync(urlApi);
            var responseBody = await response.Content.ReadAsStringAsync();
             JsonNode nodos = JsonNode.Parse(responseBody);
            JsonNode results = nodos["results"];
            var personajeData =   JsonSerializer.Deserialize<List<PersonajeResponsive.Result>>(results.ToString());
            return personajeData;
        }
    }
}