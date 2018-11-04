using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using TestDataRepositories.Interfaces;
using TestDataRepositories;
using TestWebApp.Controllers;

namespace TestWebApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private static IContainer Container { get; set; }

        protected void Application_Start()
        {  
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            

            var builder = new ContainerBuilder();
            builder.RegisterType<CategoriesRepository>().As<ICategories>();
            builder.RegisterType<HomeController>();
            //builder.RegisterType<Northwind_DBEntities>().As<INorthwind_DBEntities>();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }
    }
}
