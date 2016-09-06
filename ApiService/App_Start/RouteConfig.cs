using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using System.Net.Http.Formatting;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ApiService
{
    public class RouteConfig
    {
        public static Action<IRouteBuilder> RegisterRoutes()
        {
            return routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "api/{controller}/{action}/{id?}");
                //routes.MapWebApiRoute(
                //     name: "DefaultApi",
                //     template: "api/{controller}/{id?}"
                //    );
                //routes.MapWebApiRoute(
                //     name: "DefaultApi1",
                //     template: "api/{controller}/{action}/{id?}"
                //    );

            };
        }

    }
}
