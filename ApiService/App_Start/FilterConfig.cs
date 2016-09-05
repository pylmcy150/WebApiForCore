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
        public static Action<MvcOptions> RegisterGlobalFilters()
        {
            return options =>
            {
                options.Filters.Add(typeof(DefaultExceptionFilter)); // by type
                options.Filters.Add(typeof(LogErrorFilter));
                //options.Filters.Add(new SampleAsyncActionFilter()); // an instance
            };
        }
    }
}
