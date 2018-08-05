using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Autofac;
using System.Reflection;
using Autofac.Integration.Mvc;
using TeduShop.Data.Infrastructure;
using TeduShop.Data;
using TeduShop.Data.Repository;
using TeduShop.Service;
using System.Web.Mvc;
using System.Web.Http;
using Autofac.Integration.WebApi;

[assembly: OwinStartup(typeof(TeduShop.Web.App_Start.Startup))]

namespace TeduShop.Web.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigAutofac(app);
        }

        private void ConfigAutofac(IAppBuilder app)
        {
            var buider = new ContainerBuilder();
            buider.RegisterControllers(Assembly.GetExecutingAssembly());

            buider.RegisterApiControllers(Assembly.GetExecutingAssembly());

            buider.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            buider.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();

            buider.RegisterType<TeduShopDbContext>().AsSelf().InstancePerRequest();

            //Repository
            buider.RegisterAssemblyTypes(typeof(PostCategoryRepository).Assembly)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerRequest();

            //Service
            buider.RegisterAssemblyTypes(typeof(PostCategoryService).Assembly)
               .Where(t => t.Name.EndsWith("Service"))
               .AsImplementedInterfaces().InstancePerRequest();

            Autofac.IContainer container = buider.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver((IContainer)container);
        }
    }
}
