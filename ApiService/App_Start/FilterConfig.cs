using ApiService.Filters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiService
{
    public class FilterConfig
    {
        public static Action<MvcOptions> RegisterGlobalOptions()
        {
            return options =>
            {
                // Add XML Content Negotiation
                //options.RespectBrowserAcceptHeader = true;
                //options.InputFormatters.Add(new XmlSerializerInputFormatter());
                //options.OutputFormatters.Add(new XmlSerializerOutputFormatter());


                options.Filters.Add(typeof(DefaultExceptionFilter)); // by type
                options.Filters.Add(typeof(LogErrorFilter));
                //options.Filters.Add(new SampleAsyncActionFilter()); // an instance
            };
        }
    }
}
