using System;
using System.IO;
using Newtonsoft.Json;
using Shared.Models;

namespace NewtonSoft
{
    class Program
    {
        static void Main(string[] args)
        {
            var jsonString = File.ReadAllText("jobsettings.json");

            var root = JsonConvert.DeserializeObject<Root>(jsonString);

            Console.WriteLine("\n Service         Habilitado?     Url                            Time");

            foreach (var item in root.Jobs)
            {
                Console.WriteLine("\n {0}   {1}   {2}   {3}",
                    item.Service, item.Enabled, item.Parameters.Url, item.Parameters.Seconds);
            }
        }
    }
}
