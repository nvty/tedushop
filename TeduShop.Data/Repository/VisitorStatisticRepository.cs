using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repository
{
    public interface IVisitorStatisticRepository
    {

    }
    public class VisitorStatisticRepository:RepositoryBase<VisitorStatistic>,IVisitorStatisticRepository
    {
        public VisitorStatisticRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
