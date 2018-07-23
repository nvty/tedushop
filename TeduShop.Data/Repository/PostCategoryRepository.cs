using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repository
{
    public interface IPostCategoryRepository : IRepository<PostCategory>
    {

    }
    public class PostCatepugoryRepository:RepositoryBase<PostCategory>,IPostCategoryRepository
    {
        public PostCatepugoryRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
