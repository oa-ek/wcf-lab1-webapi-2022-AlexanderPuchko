using AutoMapper;
using AutoOA.Core;
using AutoOA.Repository.Dto.RegionDto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoOA.Repository.Repositories
{
    public class RegionRepository
    {
        private readonly AutoOADbContext _ctx;
        private readonly IMapper _mapper;

        public RegionRepository(AutoOADbContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }
        //API
        public async Task<IEnumerable<RegionReadDto>> GetListAsync() //Вивід всіх даних
        {
            return _mapper.Map<IEnumerable<RegionReadDto>>(await _ctx.Regions.ToListAsync());

        }
        public async Task<RegionReadDto> GetAsync(int id) //Вивід даних по id
        {
            return _mapper.Map<RegionReadDto>(await _ctx.Regions.FirstAsync(x => x.RegionId == id));
        }
        public async Task<int> CreateAsync(RegionCreateDto createDto)
        {
            var data = await _ctx.Regions.AddAsync(new Region { RegionName = createDto.RegionName });
            await _ctx.SaveChangesAsync();
            return data.Entity.RegionId;
        }

        //

        public async Task<Region> AddRegionAsync(Region region)
        {
            _ctx.Regions.Add(region);
            await _ctx.SaveChangesAsync();
            return _ctx.Regions.FirstOrDefault(x => x.RegionName == region.RegionName);
        }

        public List<Region> GetRegions()
        {
            var regionList = _ctx.Regions.ToList();
            return regionList;
        }

        public Region GetRegion(int id)
        {
            return _ctx.Regions.FirstOrDefault(x => x.RegionId == id);
        }

        public Region GetRegionByName(string name)
        {
            return _ctx.Regions.FirstOrDefault(x => x.RegionName == name);
        }

        public async Task DeleteRegionAsync(int id)
        {
            _ctx.Remove(GetRegion(id));
            await _ctx.SaveChangesAsync();
        }
    }
}
