using AutoMapper;
using AutoOA.Core;
using AutoOA.Repository.Dto.DriveTypeDto;
using Microsoft.EntityFrameworkCore;
using DriveType = AutoOA.Core.DriveType;

namespace AutoOA.Repository.Repositories
{
    public class DriveTypeRepository
    {
        private readonly AutoOADbContext _ctx;
        private readonly IMapper _mapper;

        public DriveTypeRepository(AutoOADbContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }
        //API
        public async Task<IEnumerable<DriveTypeReadDto>> GetListAsync() //Вивід всіх даних
        {
            return _mapper.Map<IEnumerable<DriveTypeReadDto>>(await _ctx.DriveTypes.ToListAsync());

        }
        public async Task<DriveTypeReadDto> GetAsync(int id) //Вивід даних по id
        {
            return _mapper.Map<DriveTypeReadDto>(await _ctx.DriveTypes.FirstAsync(x => x.DriveTypeId == id));
        }
        public async Task<int> CreateAsync(DriveTypeCreateDto createDto)
        {
            var data = await _ctx.DriveTypes.AddAsync(new DriveType { DriveTypeName = createDto.DriveTypeName });
            await _ctx.SaveChangesAsync();
            return data.Entity.DriveTypeId;
        }

        //
        public async Task<DriveType> AddDriveTypeAsync(DriveType type)
        {
            _ctx.DriveTypes.Add(type);
            await _ctx.SaveChangesAsync();
            return _ctx.DriveTypes.FirstOrDefault(x => x.DriveTypeName == type.DriveTypeName);
        }

        public List<DriveType> GetDriveTypes()
        {
            var typeList = _ctx.DriveTypes.ToList();
            return typeList;
        }

        public DriveType GetDriveType(int id)
        {
            return _ctx.DriveTypes.FirstOrDefault(x => x.DriveTypeId == id);
        }

        public DriveType GetDriveTypeByName(string name)
        {
            return _ctx.DriveTypes.FirstOrDefault(x => x.DriveTypeName == name);
        }

        public async Task DeleteDriveTypeAsync(int id)
        {
            _ctx.Remove(GetDriveType(id));
            await _ctx.SaveChangesAsync();
        }
    }
}
