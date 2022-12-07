using AutoMapper;
using AutoOA.Core;
using AutoOA.Repository.Dto.VehicleBrandDto;
using Microsoft.EntityFrameworkCore;

namespace AutoOA.Repository.Repositories
{
    public class VehicleBrandRepository
    {
        private readonly AutoOADbContext _ctx;
        private readonly IMapper _mapper;

        public VehicleBrandRepository(AutoOADbContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }
        //API
        public async Task<IEnumerable<VehicleBrandReadDto>> GetListAsync() //Вивід всіх даних
        {
            return _mapper.Map<IEnumerable<VehicleBrandReadDto>>(await _ctx.VehicleBrands.ToListAsync());

        }
        public async Task<VehicleBrandReadDto> GetAsync(int id) //Вивід даних по id
        {
            return _mapper.Map<VehicleBrandReadDto>(await _ctx.VehicleBrands.FirstAsync(x => x.VehicleBrandId == id));
        }
        //
        public async Task<VehicleBrand> AddVehicleBrandAsync(VehicleBrand type)
        {
            _ctx.VehicleBrands.Add(type);
            await _ctx.SaveChangesAsync();
            return _ctx.VehicleBrands.FirstOrDefault(x => x.VehicleBrandName == type.VehicleBrandName);
        }

        

        public List<VehicleBrand> GetVehicleBrands()
        {
            var brandList = _ctx.VehicleBrands.ToList();
            return brandList;
        }

        public VehicleBrand GetVehicleBrand(int id)
        {
            return _ctx.VehicleBrands.FirstOrDefault(x => x.VehicleBrandId == id);
        }

        public VehicleBrand GetVehicleBrandByName(string name)
        {
            return _ctx.VehicleBrands.FirstOrDefault(x => x.VehicleBrandName == name);
        }

        public async Task DeleteVehicleBrandAsync(int id)
        {
            _ctx.Remove(GetVehicleBrand(id));
            await _ctx.SaveChangesAsync();
        }
    }
}
