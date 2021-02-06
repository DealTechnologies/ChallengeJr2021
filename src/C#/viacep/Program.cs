using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace viacep
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Digite seu cep:");

            var cep = Console.ReadLine();

            var response = await GetJsonFromContent<Postal>("https://viacep.com.br/", $"ws/{cep}/json");

            Console.WriteLine(JsonConvert.SerializeObject(response));
        }

        static async Task<T> GetJsonFromContent<T>(string baseUri, string uri)
        {
            var client = new HttpClient { BaseAddress = new Uri(baseUri) };

            var request = new HttpRequestMessage(HttpMethod.Get, uri);

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                try
                {
                    return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

            return default;
        }
    }

    internal class Postal
    {
        [JsonPropertyName("logradouro")]
        public string Logradouro { get; set; }

        [JsonPropertyName("bairro")] 
        public string Bairro { get; set; }

        [JsonPropertyName("uf")] 
        public string Uf { get; set; }
    }
}
