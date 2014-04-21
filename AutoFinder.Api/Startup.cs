using System;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin;
using Ninject;
using Owin;
using Ninject.Web.Common;

[assembly: OwinStartup(typeof(AutoFinder.Api.Startup))]

namespace AutoFinder.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute("cars", "api/{Controller}");

            //Make ninject work
            
            var kernel = new StandardKernel();
            kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
            config.DependencyResolver = new NinjectDependencyResolver(kernel);
            //kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

            kernel.Bind<ICarController>().To<CarController>();
            app.UseWebApi(config);
        }
    }
}
