using AutoOA.Core;
using AutoOA.Repository.Dto.BodyTypeDto;
using AutoOA.Repository.Dto.VehicleBrandDto;
using Microsoft.EntityFrameworkCore;

namespace AutoOA.Repository.Repositories
{
    public class VehicleBrandRepository
    {
        private readonly AutoOADbContext _ctx;

        public VehicleBrandRepository(AutoOADbContext ctx)
        {
            _ctx = ctx;
        }

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
