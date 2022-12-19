using System.Net.Http.Json;

namespace AutoOABlazor.Client.Services
{
    public class VehicleService : BaseService
    {
        public VehicleService(HttpClient httpClient)
           : base(httpClient) { }

        public async Task<IEnumerable<VehicleReadDto>> GetVehiclesAsync()
        {
           return await Client.GetFromJsonAsync<IEnumerable<VehicleReadDto>>("/vehicle");
        }

        //public async Task<int> CreateTimetablesAsync(TimetableCreateDto time)
        //{
           // var msg = await httpClient.PostAsJsonAsync<TimetableCreateDto>("/api/timetables", time);
            //return int.Parse(await msg.Content.ReadAsStringAsync());
        //}

        public async Task<VehicleReadDto> GetAsync(int id)
        {
            return await Client.GetFromJsonAsync<VehicleReadDto>($"/api/vehicles/{id}");
        }
    }
}
