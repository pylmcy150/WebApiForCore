using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

namespace ApiService
{
    public class RouteConfig
    {
        public static Action<IRouteBuilder> RegisterRoutes()
        {
            return routes =>
            {
                //routes.MapRoute(
                //    name: "default",
                //    template: "api/{controller}/{action}/{id?}");

            };
        }
    }
}
