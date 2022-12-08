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
        //API
        public async Task<IEnumerable<FuelTypeReadDto>> GetListAsync() //Вивід всіх даних
        {
            return _mapper.Map<IEnumerable<FuelTypeReadDto>>(await _ctx.FuelTypes.ToListAsync());

        }
        public async Task<FuelTypeReadDto> GetAsync(int id) //Вивід даних по id
        {
            return _mapper.Map<FuelTypeReadDto>(await _ctx.FuelTypes.FirstAsync(x => x.FuelTypeId == id));
        }
        public async Task<int> CreateAsync(FuelTypeCreateDto createDto) //Створення даних
        {
            var data = await _ctx.FuelTypes.AddAsync(new FuelType { FuelTypeName = createDto.FuelTypeName });
            await _ctx.SaveChangesAsync();
            return data.Entity.FuelTypeId;
        }

        //

        public async Task<FuelType> AddFuelTypeAsync(FuelType type)
        {
            _ctx.FuelTypes.Add(type);
            await _ctx.SaveChangesAsync();
            return _ctx.FuelTypes.FirstOrDefault(x => x.FuelTypeName == type.FuelTypeName);
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
            return _ctx.FuelTypes.FirstOrDefault(x => x.FuelTypeName == name);
        }

        public async Task DeleteFuelTypeAsync(int id)
        {
            _ctx.Remove(GetFuelType(id));
            await _ctx.SaveChangesAsync();
        }
    }
}
