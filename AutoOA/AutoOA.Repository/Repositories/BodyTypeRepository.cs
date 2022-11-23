using AutoOA.Core;

namespace AutoOA.Repository.Repositories
{
    public class BodyTypeRepository
    {
        private readonly AutoOADbContext _ctx;

        public BodyTypeRepository(AutoOADbContext ctx)
        {
            _ctx = ctx;
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
