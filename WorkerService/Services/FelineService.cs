using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WorkerService.Models;

namespace WorkerService.Services
{
    public class FelineService : IFelineService
    {
        private readonly HttpClient _httpClient;

        public FelineService()
        {
            _httpClient = new HttpClient();   
        }
        public async Task<FelineFact> GetFelineFact()
        {
            var message = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://catfact.ninja/fact")
            };

            var response = await _httpClient.SendAsync(message);
            string responseText = await response.Content.ReadAsStringAsync();
            var fact = JsonSerializer.Deserialize<FelineFact>(responseText);
            return fact; 
        }
    }
}
