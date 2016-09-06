using ApiService.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;

namespace ApiService.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    public class DefaultExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            if (context != null && context.ExceptionHandled)
            {
                //JsonResult js = new JsonResult(context.Exception.Message);
                //js.StatusCode = HttpStatusCode.InternalServerError;
                //context.Result = new ExceptionResult(context.Exception, true);

                //context.Result = new JsonResult("123");
                //var exception = new ExceptionResult(context.Exception, false);
                //context.HttpContext.Response.StatusCode =
                //    exception.StatusCode.HasValue ? exception.StatusCode.Value : (int)HttpStatusCode.NotImplemented;
                context.ExceptionHandled = true;
                //context.HttpContext.Response.StatusCode = (int)HttpStatusCode.NoContent;
                //context.Result = new RedirectToActionResult("Test", "Values", new RouteValueDictionary() {  });
            }
        }
    }
}
