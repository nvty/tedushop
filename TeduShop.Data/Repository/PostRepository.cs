using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repository
{
    public interface IPostRepository : IRepository<Post>
    {

    }
    public class PostRepository:RepositoryBase<Post>,IPostRepository
    {
        public PostRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
