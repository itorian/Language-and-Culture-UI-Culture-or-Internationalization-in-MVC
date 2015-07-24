using System.Web.Mvc;
using System.Web.Routing;
using WebApplication2.App_GlobalResources;
using WebApplication2.ModelMetadataExtension;

namespace WebApplication2
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            ModelMetadataProviders.Current = new ConventionalModelMetadataProvider(false, typeof(Resource));

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            
        }
    }
}
