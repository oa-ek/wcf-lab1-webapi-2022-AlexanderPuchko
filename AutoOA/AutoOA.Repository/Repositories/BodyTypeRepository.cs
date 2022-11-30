using AutoMapper;
using AutoOA.Core;
using AutoOA.Repository.Dto.BodyTypeDto;
using Microsoft.EntityFrameworkCore;

namespace AutoOA.Repository.Repositories
{
    public class BodyTypeRepository
    {
        private readonly AutoOADbContext _ctx;
        private readonly IMapper _mapper;

        public BodyTypeRepository(AutoOADbContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }

        public async Task<IEnumerable<BodyTypeReadDto>> GetListAsync()
        {
            return _mapper.Map<IEnumerable<BodyTypeReadDto>>(await _ctx.BodyTypes.ToListAsync());

        }

        public async Task<BodyType> AddBodyTypeAsync(BodyType type)
        {
            _ctx.BodyTypes.Add(type);
            await _ctx.SaveChangesAsync();
            return _ctx.BodyTypes.FirstOrDefault(x => x.BodyTypeName == type.BodyTypeName);
        }

        public List<BodyType> GetBodyTypes()
        {
            var bodyList = _ctx.BodyTypes.ToList();
            return bodyList;
        }

        public BodyType GetBodyType(int id)
        {
            return _ctx.BodyTypes.FirstOrDefault(x => x.BodyTypeId == id);
        }

        public BodyType GetBodyTypeByName(string name)
        {
            return _ctx.BodyTypes.FirstOrDefault(x => x.BodyTypeName == name);
        }

        public async Task DeleteBodyTypeAsync(int id)
        {
            _ctx.Remove(GetBodyType(id));
            await _ctx.SaveChangesAsync();
        }        
    }
}
