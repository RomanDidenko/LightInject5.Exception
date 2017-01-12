namespace Pr2
{
    using System.Web.Http;
    using Owin;

    using Pr2.LightInject;
    using Pr2.LightInject.WebApi;

    //using Pr1.LightInject;
    //using Pr1.LightInject.WebApi;

    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            var config = new HttpConfiguration();

            var container = new ServiceContainer();
            container.Register<IFoo, Foo>(new PerScopeLifetime());

            container.RegisterApiControllers();
            container.EnableWebApi(config);
            container.ScopeManagerProvider = new PerLogicalCallContextScopeManagerProvider();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{id}",
                defaults: new { id = RouteParameter.Optional, controller = "default" }
            );

            appBuilder.UseWebApi(config);
        }
    }
}
