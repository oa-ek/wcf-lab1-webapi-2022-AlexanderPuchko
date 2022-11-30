using AutoMapper;
using AutoOA.Core;
using AutoOA.Repository.Dto.FuelTypeDto;
using Microsoft.EntityFrameworkCore;

namespace AutoOA.Repository.Repositories
{
    public class FuelTypeRepository
    {
        private readonly AutoOADbContext _ctx;
        private readonly IMapper _mapper;

        public FuelTypeRepository(AutoOADbContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }

        public async Task<IEnumerable<FuelTypeReadDto>> GetListAsync()
        {
            return _mapper.Map<IEnumerable<FuelTypeReadDto>>(await _ctx.BodyTypes.ToListAsync());

        }

        public async Task<FuelType> AddFuelTypeAsync(FuelType type)
        {
            _ctx.FuelTypes.Add(type);
            await _ctx.SaveChangesAsync();
            return _ctx.FuelTypes.FirstOrDefault(x => x.FuelName == type.FuelName);
        }

        public List<FuelType> GetFuelTypes()
        {
            var typeList = _ctx.FuelTypes.ToList();
            return typeList;
        }

        public FuelType GetFuelType(int id)
        {
            return _ctx.FuelTypes.FirstOrDefault(x => x.FuelTypeId == id);
        }

        public FuelType GetFuelTypeByName(string name)
        {
            return _ctx.FuelTypes.FirstOrDefault(x => x.FuelName == name);
        }

        public async Task DeleteFuelTypeAsync(int id)
        {
            _ctx.Remove(GetFuelType(id));
            await _ctx.SaveChangesAsync();
        }
    }
}
