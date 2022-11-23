using AutoOA.Core;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text.Json;

var ModelData = JsonConvert.DeserializeObject<List<VehicleModel>>(File.ReadAllText(@"C:\Users\vadym\OneDrive\Робочий стіл\cars.csv"));

foreach (var data in ModelData)
{
    Console.WriteLine($"ff {data.VehicleModelName}");
}