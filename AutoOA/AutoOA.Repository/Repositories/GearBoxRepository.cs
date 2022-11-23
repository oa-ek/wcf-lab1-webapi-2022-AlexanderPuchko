using AutoOA.Core;
using AutoOA.Repository.Dto.GearBoxDto;
using Microsoft.EntityFrameworkCore;

namespace AutoOA.Repository.Repositories
{
    public class GearBoxRepository
    {
        private readonly AutoOADbContext _ctx;

        public GearBoxRepository(AutoOADbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<GearBox> AddGearBoxAsync(GearBox gear)
        {
            _ctx.GearBoxes.Add(gear);
            await _ctx.SaveChangesAsync();
            return _ctx.GearBoxes.FirstOrDefault(x => x.GearBoxName == gear.GearBoxName);
        }

        public List<GearBox> GetGearBoxes()
        {
            var gearList = _ctx.GearBoxes.ToList();
            return gearList;
        }

        public GearBox GetGearBox(int id)
        {
            return _ctx.GearBoxes.FirstOrDefault(x => x.GearBoxId == id);
        }

        public GearBox GetGearBoxByName(string name)
        {
            return _ctx.GearBoxes.FirstOrDefault(x => x.GearBoxName == name);
        }

        public async Task DeleteGearBoxAsync(int id)
        {
            _ctx.Remove(GetGearBox(id));
            await _ctx.SaveChangesAsync();
        }
    }
}
