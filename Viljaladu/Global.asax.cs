using System;
using System.Collections.Generic;
using System.Linq;
using Viljaladu.DAL;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Viljaladu
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

			var autoContext = new AutoContext();
			Database.SetInitializer(new AutoInitializer());
			autoContext.Database.Initialize(true);
        }
    }
}
