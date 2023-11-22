using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Text.Json.Serialization;


namespace PrograminExercise9
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // 1 API request for random activities
            string useranswer;
            bool check;
            HttpClient client = new HttpClient();
            string ApiUrl = "https://www.boredapi.com/api/activity";
            do
            {
                await Console.Out.WriteLineAsync("New Activity for you");
                var result = await client.GetStringAsync(ApiUrl);
                var activity = JsonConvert.DeserializeObject<Bored>(result);
                await Console.Out.WriteLineAsync("");
                await Console.Out.WriteLineAsync("");
                Console.WriteLine(activity.Activity);
                await Console.Out.WriteLineAsync("");
                await Console.Out.WriteLineAsync("");
                Console.WriteLine("Do you want new activity? (yes/no)");
                useranswer = Console.ReadLine();
                if (useranswer == "yes")
                {
                    check = true;
                }
                else
                    check = false;
            } while (check);

            // 2 APi request for Predicting the gender of a person based on their name.
            HttpClient client1 = new HttpClient();
            string APIURL1 = "https://api.genderize.io?name=";
            string name;
            do
            {
                await Console.Out.WriteLineAsync("");
                await Console.Out.WriteLineAsync("Input the name which you want to check");
                name = Console.ReadLine();
                var resultname = await client1.GetStringAsync(APIURL1 + name);
                var checkname = JsonConvert.DeserializeObject<CheckName>(resultname);
                await Console.Out.WriteLineAsync("");
                await Console.Out.WriteLineAsync(checkname.Gender);
                await Console.Out.WriteLineAsync("If you want stop write stop if you want continue input name again");
                if (Console.ReadLine() == "stop")
                {
                    check = false;
                }

            } while (check);

            // 3 API request for Predicting the nationality of a name
            HttpClient client2 = new HttpClient();
            string nameinput;
            string APIUrl2 = "https://api.nationalize.io?name=";
            while (check = true)
            {
                await Console.Out.WriteLineAsync("");
                await Console.Out.WriteLineAsync("Input name which you want to check");
                nameinput = Console.ReadLine();
                var nationalty = await client2.GetStringAsync(APIUrl2 + name);
                var jsonData = JObject.Parse(nationalty)["country"];

                foreach (var country in jsonData)
                {
                    Console.WriteLine($"Country ID: {country["country_id"]}, Probability: {country["probability"]}");
                }

                check = false;
            }
        }
        public class Bored
        {
            public string Activity { get; set; }
            public string Type { get; set; }
            public string Participiants { get; set; }
            public string Price { get; set; }
            public string Link { get; set; }
            public string Key { get; set; }
            public string Accsessibility { get; set; }


        }

        public class CheckName
        {
            public string Gender { get; set; }
        }

        public class CheckNationalty
        {
            public Array Country { get; set; }

        }
    }
}
