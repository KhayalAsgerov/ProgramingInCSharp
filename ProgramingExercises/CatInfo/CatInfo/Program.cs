using Newtonsoft.Json;
using System.Net.Http;
using System.Text.Json.Nodes;

namespace Catinfo
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();
            bool check = true;
            const string apiUrl = "https://catfact.ninja/fact?max_length=140";
            do
            {
                var response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Cat Fact:");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;
                    var result = JsonConvert.DeserializeObject<CatFact>(content);
                    Console.WriteLine(result.Fact);
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("HTTP request failed with status code: " + response.StatusCode);
                }

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Do you want to continue (yes or no)");
                Console.ResetColor();
                string answer = Console.ReadLine();
                check = (answer.ToLower() == "yes");
                Console.WriteLine();
            } while (check);

        }
        public class CatFact
        {
            public string Fact { get; set; }
            public int Length { get; set; }
        }
       
    }
    }

