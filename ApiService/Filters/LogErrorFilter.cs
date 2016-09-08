using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiService.Filters
{
    public class LogErrorFilter : Attribute, IExceptionFilter
    {
        private readonly ILogger<LogErrorFilter> logger;

        public LogErrorFilter(ILogger<LogErrorFilter> log)
        {
            logger = log;
        }

        public void OnException(ExceptionContext context)
        {
            if (!context.ExceptionHandled)
            {
                string controllerName = (string)context.RouteData.Values["controller"];
                string actionName = (string)context.RouteData.Values["action"];
                string msgTemplate = "在执行 controller[{0}] 的 action[{1}] 时产生异常,Error[{2}]";
                logger.LogInformation(string.Format(msgTemplate, controllerName, actionName, context.Exception.Message));
            }
        }
    }
}
