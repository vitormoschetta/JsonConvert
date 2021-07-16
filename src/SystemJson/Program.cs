using System;
using System.IO;
using System.Text.Json;
using SystemJson.Models;

namespace SystemJson
{
    class Program
    {
        static void Main(string[] args)
        {
            var jsonString = File.ReadAllText("jobsettings.json");

            var root = JsonSerializer.Deserialize<Root2>(jsonString);

            Console.WriteLine("\n Service         Habilitado?     Url                            Time");

            // foreach (var item in root.Jobs)
            // {
            //     Console.WriteLine("\n {0}   {1}   {2}   {3}",
            //         item.Service, item.Enabled, item.Parameters.Url, item.Parameters.Seconds);
            // }

            foreach (var item in root.Tarefas)
            {
                Console.WriteLine("\n {0}   {1}   {2}   {3}",
                    item.Servico, item.Habilitado, item.Parametros.Url, item.Parametros.Segundos);
            }
        }
    }
}
