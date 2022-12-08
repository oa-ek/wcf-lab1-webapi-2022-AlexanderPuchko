﻿using AutoMapper;
using AutoOA.Core;
using AutoOA.Repository.Dto.RegionDto;
using AutoOA.Repository.Dto.SalesDataDto;
using Microsoft.EntityFrameworkCore;

namespace AutoOA.Repository.Repositories
{
    public class SalesDataRepository
    {
        private readonly AutoOADbContext _ctx;
        private readonly IMapper _mapper;

        public SalesDataRepository(AutoOADbContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }
        //API
        public async Task<IEnumerable<SalesDataReadDto>> GetListAsync() //Вивід всіх даних
        {
            return _mapper.Map<IEnumerable<SalesDataReadDto>>(await _ctx.SalesData.ToListAsync());

        }
        public async Task<SalesDataReadDto> GetAsync(int id) //Вивід даних по id
        {
            return _mapper.Map<SalesDataReadDto>(await _ctx.SalesData.FirstAsync(x => x.SalesDataId == id));
        }
        //

        public SalesData GetDataByCreatedData(DateTime time)
        {
            return _ctx.SalesData.FirstOrDefault(x => x.CreatedOn == time);
        }

        public List<SalesData> GetSaleDatas()
        {
            var dataList = _ctx.SalesData.ToList();
            return dataList;
        }

        public SalesData GetSaleData(int id)
        {
            return _ctx.SalesData.FirstOrDefault(x => x.SalesDataId == id);
        }
    }
}
