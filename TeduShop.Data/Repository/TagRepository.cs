using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repository
{
    public interface ITagRepository
    {

    }
    public class TagRepository:RepositoryBase<Tag>,ITagRepository
    {
        public TagRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
