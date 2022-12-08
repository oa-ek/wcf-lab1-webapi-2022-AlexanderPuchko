using AutoMapper;
using AutoOA.Core;
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

        //API
        public async Task<IEnumerable<VehicleModelReadDto>> GetListAsync() //Вивід всіх даних
        {
            return _mapper.Map<IEnumerable<VehicleModelReadDto>>(await _ctx.VehicleModels.ToListAsync());

        }
        public async Task<VehicleModelReadDto> GetAsync(int id) //Вивід даних по id
        {
            return _mapper.Map<VehicleModelReadDto>(await _ctx.VehicleModels.FirstAsync(x => x.VehicleModelId == id));
        }
        public async Task<int> CreateAsync(VehicleModelCreateDto createDto) //Створення даних
        {
            var data = await _ctx.VehicleModels.AddAsync(new VehicleModel {VehicleModelName = createDto.VehicleModelName});
            await _ctx.SaveChangesAsync();
            return data.Entity.VehicleModelId;
        }
        public async Task Update(int id, VehicleModelCreateDto modelDto)
        {
            var model = _ctx.VehicleModels.FirstOrDefault(x => x.VehicleModelId == id);
            model.VehicleModelName = modelDto.VehicleModelName;
            await _ctx.SaveChangesAsync();
        }
        public async Task DeleteVehicleModelAsync(int id)
        {
            _ctx.Remove(GetVehicleModel(id));
            await _ctx.SaveChangesAsync();
        }
        //

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

        
    }
}
