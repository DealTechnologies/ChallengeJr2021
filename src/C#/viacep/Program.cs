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

            await GetJsonFromContent("https://viacep.com.br/", $"ws/{cep}/json");
        }

        static async Task GetJsonFromContent(string baseUri, string uri)
        {
            var client = new HttpClient { BaseAddress = new Uri(baseUri) };

            var request = new HttpRequestMessage(HttpMethod.Get, uri);

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                try
                {
                    Console.WriteLine(await response.Content.ReadAsStringAsync());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
    }
}
