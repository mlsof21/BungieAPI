using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net.Http;
using System.Net;
using System.Data.SQLite;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using BungieAPI.Definitions;

namespace BungieAPI
{
    class Program
    {
        public static string apikey = "897a3b5426fb4564b05058cad181b602";

        static async Task Main()
        {
            string baseURL = "https://www.bungie.net/platform/";

            //Download the manifest
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-API-Key", apikey);

                var response = client.GetAsync(baseURL + "Destiny/Manifest/").Result;
                var content = response.Content.ReadAsStringAsync().Result;
                dynamic item = JsonConvert.DeserializeObject(content);
                string manifestUrl = item.Response.mobileWorldContentPaths.en;

                Console.WriteLine(manifestUrl);

                Functions f = new Functions();

                await f.DownloadManifest("https://www.bungie.net" + manifestUrl);
            }

            string sqlitePath = Functions.GetSqlitePath();

            //Read from the sqlite db
            using (var conn = new SQLiteConnection($"Data Source={sqlitePath};Version=3"))
            {
                conn.Open();
                long val = 2803282938;
                long i = 1;
                val = val - (i << 32);
                string sql = $"Select json from DestinyRaceDefinition WHERE id = {val}";
                SQLiteCommand command = new SQLiteCommand(sql, conn);
                SQLiteDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.KeyInfo);

                while (reader.Read())
                {

                    //var id = reader.GetInt64(0);
                    var data = reader.GetString(0);
                    dynamic item = JsonConvert.DeserializeObject(data);
                    var x = JObject.Parse(data);
                    Console.WriteLine($"json:{item.raceName}");// + item.displayProperties.name);
                }
                reader.Close();
                conn.Close();
            }
            Functions.BuildClassDefinitionFiles();
                //Gjallarhorn inventory item
                /*
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("X-API-Key", apikey);

                    var response = client.GetAsync(baseURL + "Destiny/Manifest/InventoryItem/1274330687/").Result;
                    var content = response.Content.ReadAsStringAsync().Result;
                    dynamic item = JsonConvert.DeserializeObject(content);

                    Console.WriteLine(item.Response.data.inventoryItem.itemName);
                }

                //Search for user
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("X-API-Key", apikey);

                    StringBuilder url = new StringBuilder();

                    Console.WriteLine("What platform?");
                    string type = Console.ReadLine();
                    int membershipType = Functions.DeterminePlatform(type);

                    Console.WriteLine("Who are you searching for?");
                    string displayName = WebUtility.UrlEncode(Console.ReadLine());

                    url.AppendFormat(baseURL + $"Destiny2/SearchDestinyPlayer/{membershipType}/{displayName}/");

                    var response = client.GetAsync(url.ToString()).Result;
                    var content = response.Content.ReadAsStringAsync().Result;
                    dynamic item = JsonConvert.DeserializeObject(content);

                    string membershipID = item.Response[0].membershipId;
                    Console.WriteLine(membershipID);
                }
                */
                Console.ReadLine();
        }

        
    }
}
