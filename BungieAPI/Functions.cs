using System;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.ComponentModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data.SQLite;
using Microsoft.Build.Evaluation;

namespace BungieAPI
{
    public class Functions
    {
        public static string databasePath { get; set; }
        private static string projectPath = @"C:\Users\Matthew Sherrill\Projects\BungieAPI\BungieAPI\";

        //download the manifest
        public async Task DownloadManifest(string url)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    string date = DateTime.Now.ToString("yyyyMMdd");
                    string filePath = Directory.GetCurrentDirectory();
                    filePath = filePath.Substring(0, 55) + "Manifest\\";

                    string fileName = $"destiny_manifest_{date}";
                    string fileExt = ".zip";
                    string zipfullPath = $"{filePath}{fileName}{fileExt}";

                    //string sqlitePath = "";
                    if (!File.Exists(zipfullPath))
                    {
                        await client.DownloadFileTaskAsync(new Uri(url), $"{zipfullPath}");
                    }
                    if(databasePath == null)
                    {
                        databasePath = zipfullPath.Replace(".zip", ".sqlite3");
                    }

                    if (!File.Exists(zipfullPath.Replace(".zip", ".sqlite3")))
                    {
                        UnzipFile(zipfullPath);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Unable to download file. Error:{0}", e.Message);
                //return false;
            }
        }

        public static void UnzipFile(string fullPath)
        {
            using (ZipArchive archive = ZipFile.OpenRead($"{fullPath}"))
            {
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    string newFullPath = fullPath.Replace(".zip", ".sqlite3");
                    entry.ExtractToFile($"{newFullPath}");
                    databasePath = newFullPath;
                }
            }
        }

        public static string GetSqlitePath()
        {
            return databasePath;
        }

        //Switch structure to determine which platform the user wants to query
        //TODO: eventually make this selectable with UI
        public static int DeterminePlatform(string inputType)
        {
            int typeID;
            switch (inputType.ToLower())
            {
                case "xbox":
                case "x box":
                    typeID = (int)Enums.MembershipTypes.TigerXbox;
                    break;
                case "ps4":
                case "playstation":
                case "playstation4":
                case "playstation 4":
                case "psn":
                    typeID = (int)Enums.MembershipTypes.TigerPsn;
                    break;
                case "pc":
                case "battle.net":
                case "battlenet":
                case "bnet":
                case "blizzard":
                case "battle net":
                    typeID = (int)Enums.MembershipTypes.TigerBlizzard;
                    break;
                case "all":
                    typeID = (int)Enums.MembershipTypes.All;
                    break;
                default:
                    typeID = (int)Enums.MembershipTypes.None;
                    break;
            }

            return typeID;
        }

        //NOT NEEDED
        //public static T Deserialize<T>(byte[] data) where T : class
        //{
        //    using (var stream = new MemoryStream(data))
        //    using (var reader = new StreamReader(stream, Encoding.UTF8))
        //        return JsonSerializer.Create().Deserialize(reader, typeof(T)) as T;
        //}
        //
        //public static byte[] ObjectToByteArray(Object obj)
        //{
        //    if (obj == null)
        //        return null;
        //    BinaryFormatter bf = new BinaryFormatter();
        //    MemoryStream ms = new MemoryStream();
        //    bf.Serialize(ms, obj);
        //    return ms.ToArray();
        //}

        public static List<object> QueryDatabase(string database, string sql)
        {
            List<object> res = new List<object>();
            using (var conn = new SQLiteConnection($"Data Source={database};Version=3"))
            {
                conn.Open();
                SQLiteCommand command = new SQLiteCommand(sql, conn);
                SQLiteDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.KeyInfo);

                while (reader.Read())
                {
                    var data = reader["json"].ToString();
                    dynamic item = JsonConvert.DeserializeObject(data);
                    res.Add(item);                   
                }
                reader.Close();
                conn.Close();
            }

            return res;
        }

        public static string BuildSQL(string table, List<string> columns, string hash = null)
        {
            StringBuilder sb = new StringBuilder();
            long val;

            sb.Append($"SELECT ");
            sb.Append(String.Join(",", columns) + " ");
            sb.Append($"FROM {table} ");

            //Only add where clause if hash isn't null. 
            //We know there is an id to hash against if present.
            if (hash != null)
            {
                val = GetHashValue(hash);
                sb.Append($"WHERE id={val}");
            }

            return sb.ToString();
        }

        public static long GetHashValue(string hash)
        {
            long i = 1;
            long val = long.Parse(hash);
            long result = val - (i << 32);            
            return val;
        }

        public static bool BuildClassDefinitionFiles()
        {
            DeleteFilesFromDefinitionsDirectory();

            try
            {
                using (var conn = new SQLiteConnection($"Data Source={databasePath};Version=3"))
                {
                    conn.Open();
                    string sql = BuildSQL("sqlite_master", new List<string> { "tbl_name" });
                    SQLiteCommand command = new SQLiteCommand(sql, conn);
                    SQLiteDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.KeyInfo);

                    while (reader.Read())
                    {
                        var table = reader.GetString(0);
                        GetJsonForClass(table);
                    }
                    reader.Close();
                    conn.Close();
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public static string GetJsonForClass(string tableName)
        {
            using (var conn = new SQLiteConnection($"Data Source={databasePath};Version=3"))
            {
                conn.Open();

                string sql = BuildSQL(tableName, new List<string> { "json" });
                SQLiteCommand command = new SQLiteCommand(sql, conn);
                SQLiteDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.KeyInfo);

                //while (reader.Read())
                //{
                reader.Read();
                var jo = JObject.Parse(reader.GetString(0));

                Dictionary<string, string> list = new Dictionary<string, string>();

                //dynamic item = JsonConvert.DeserializeObject(data);
                foreach (var i in jo)
                {
                    if (i.Value.Type == JTokenType.Integer)
                    {
                        list.Add(i.Key.ToString(), "long");
                    }
                    else
                    {
                        list.Add(i.Key.ToString(), "string");
                    }
                }
                CreateClassDefinitionFile($"{tableName}", list);
                //}
                reader.Close();
                conn.Close();
            }

            return "";
        }

        public static string CreateClassDefinitionFile(string tableName, Dictionary<string, string> list)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("using System;\n" +
                      "using System.Collections.Generic;\n" +
                      "using System.Linq;\n" +
                      "using System.Text;\n" +
                      "using System.Threading.Tasks;\n" +
                      "\n" +
                      "namespace BungieAPI.Definitions\n" +
                      "{\n" +
                     $"    public class {tableName}\n" +
                      "    {\n");
            foreach (KeyValuePair<string, string> e in list)
            {
                sb.Append($"        public {e.Value} {e.Key}" + " { get; set; }\n");
            }
            sb.Append("    }\n" +
                      "}\n");


            System.IO.File.WriteAllText($@"C:\Users\Matthew Sherrill\Projects\BungieAPI\BungieAPI\Definitions\{tableName}.cs", sb.ToString());

            //IncludeFileInProject($@"Definitions\{tableName}.cs");


            return sb.ToString();
        }

        private static void IncludeFileInProject(string filePath)
        {
            var p = ProjectCollection.GlobalProjectCollection.LoadedProjects.FirstOrDefault(pr => pr.FullPath == $@"{projectPath}BungieAPI.csproj");

            

            if (p == null)
            {
                //p = new Project($@"{projectPath}BungieAPI.csproj");
                p = new Project(@"C:\Users\Matthew Sherrill\Projects\BungieAPI\BungieAPI\BungieAPI.csproj");
            }

            //var p = new Project(projectPath + "BungieAPI.csproj");
            p.AddItem("Compile", filePath);
            p.Save();

        }

        private static void DeleteFilesFromDefinitionsDirectory()
        {
            DirectoryInfo di = new DirectoryInfo(projectPath + @"Definitions\");

            foreach(FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
        }
    }
}
