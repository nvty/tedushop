using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repository
{
    public interface ISystemConfigRepository
    {

    }
    public class SystemConfigRepository:RepositoryBase<SystemConfig>,ISystemConfigRepository
    {
        public SystemConfigRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
