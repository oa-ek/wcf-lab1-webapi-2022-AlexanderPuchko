using AutoMapper;
using AutoOA.Core;
using AutoOA.Repository.Dto.BodyTypeDto;
using AutoOA.Repository.Dto.VehicleBrandDto;
using AutoOA.Repository.Dto.VehicleModelDto;
using Microsoft.EntityFrameworkCore;

namespace AutoOA.Repository.Repositories
{
    public class VehicleModelRepository
    {
        private readonly AutoOADbContext _ctx;
        private readonly IMapper _mapper;

        public VehicleModelRepository(AutoOADbContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }

        public async Task<IEnumerable<VehicleModelReadDto>> GetListAsync()
        {
            return _mapper.Map<IEnumerable<VehicleModelReadDto>>(await _ctx.VehicleModels.ToListAsync());

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
