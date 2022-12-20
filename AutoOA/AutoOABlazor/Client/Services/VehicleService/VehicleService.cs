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


        public async Task<VehicleReadDto> GetAsync(int id)
        {
            return await Client.GetFromJsonAsync<VehicleReadDto>($"/api/vehicle/{id}");
        }
    }
}
