using AutoOA.Core;
using AutoOA.Repository.Dto.BodyTypeDto;
using AutoOA.Repository.Dto.VehicleModelDto;
using Microsoft.EntityFrameworkCore;

namespace AutoOA.Repository.Repositories
{
    public class VehicleModelRepository
    {
        private readonly AutoOADbContext _ctx;

        public VehicleModelRepository(AutoOADbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<VehicleModel> AddVehicleModelAsync(VehicleModel model)
        {
            _ctx.VehicleModels.Add(model);
            await _ctx.SaveChangesAsync();
            return _ctx.VehicleModels.FirstOrDefault(x => x.VehicleModelName == model.VehicleModelName);
        }

        public VehicleModel GetVehicleModel(int id)
        {
            return _ctx.VehicleModels.Include(x => x.VehicleBrand).FirstOrDefault(x => x.VehicleModelId == id);
        }

        public VehicleModel GetVehicleModelByName(string name)
        {
            return _ctx.VehicleModels.Include(x => x.VehicleBrand).FirstOrDefault(x => x.VehicleModelName == name);
        }

        public List<VehicleModel> GetVehicleModels()
        {
            var modelList = _ctx.VehicleModels.ToList();
            return modelList;
        }

        public async Task DeleteVehicleModelAsync(int id)
        {
            _ctx.Remove(GetVehicleModel(id));
            await _ctx.SaveChangesAsync();
        }
    }
}
