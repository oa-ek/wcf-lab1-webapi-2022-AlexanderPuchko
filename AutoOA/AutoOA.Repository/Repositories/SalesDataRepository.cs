using AutoOA.Core;

namespace AutoOA.Repository.Repositories
{
    public class SalesDataRepository
    {
        private readonly AutoOADbContext _ctx;

        public SalesDataRepository(AutoOADbContext ctx)
        {
            _ctx = ctx;
        }

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
