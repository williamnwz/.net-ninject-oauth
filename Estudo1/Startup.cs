using Estudo1.WebApi.App_Start;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Security.OAuth;
using Ninject.Web.Common.OwinHost;
using Ninject.Web.WebApi.OwinHost;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Estudo1
{
    public class Startup
    {

        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration configuration = new HttpConfiguration();

            ConfigureWebApi(configuration);

            ConfigureOAuth(app);

            app.UseCors(CorsOptions.AllowAll);

            app.UseWebApi(configuration);

            app.UseNinjectMiddleware(NinjectWebCommon.CreateKernel);

            app.UseNinjectWebApi(configuration);

        }


        public static void ConfigureWebApi(HttpConfiguration configuration)
        {
            configuration.MapHttpAttributeRoutes();

            configuration.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
                );

      
        }


        public void ConfigureOAuth(IAppBuilder app)
        {
            OAuthAuthorizationServerOptions oAuthAuthorization = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/api/security/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromMinutes(30),
                Provider = new AuthorizationServerProvider()
            };

            app.UseOAuthAuthorizationServer(oAuthAuthorization);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

        }


    }
}