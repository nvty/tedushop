using System;
using System.Collections.Generic;
using System.Text;

namespace TeduShop.Data.Infrastructure
{
    public interface IDbFactory:IDisposable
    {
        TeduShopDbContext Init();
    }
}
