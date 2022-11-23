using AutoOA.Core;
using DriveType = AutoOA.Core.DriveType;

namespace AutoOA.Repository.Repositories
{
    public class DriveTypeRepository
    {
        private readonly AutoOADbContext _ctx;

        public DriveTypeRepository(AutoOADbContext ctx)
        {
            _ctx = ctx;
        }

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
