using Autofac;
using Autofac.Integration.Mvc;
using Data;
using Data.Repository;
using Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            #region Dependency Inject

            var builder = new ContainerBuilder();

            // Register mvc controllers
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // Register blog context
            builder.Register<IDbContext>(c => new BlogContext("ConnectionString")).InstancePerLifetimeScope();
            
            // Register EFRepository
            builder.RegisterGeneric(typeof(EfRepository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();

            // Register services
            builder.RegisterType<PostService>().As<IPostService>().InstancePerLifetimeScope();

            var container = builder.Build();

            // Set MVC DI resolver to use our Autofac container
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            #endregion
        }
    }
}
