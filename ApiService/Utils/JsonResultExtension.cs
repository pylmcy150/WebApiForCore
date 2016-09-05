using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiService.Utils
{
    public class JsonResultExtension : JsonResult
    {
        public JsonResultStatus Code { get; protected set; }

        public string Message { get; protected set; }


        public JsonResultExtension(JsonResultStatus code, string message) :
            base(message)
        {
            Code = code;
            Message = message;
            base.StatusCode = (int)code;
        }
    }

    public enum JsonResultStatus : int
    {
        /// <summary>
        /// 错误
        /// </summary>
        Error = 0,
        /// <summary>
        /// 成功
        /// </summary>
        Success,
        /// <summary>
        /// 其他
        /// </summary>
        Other,
    }
}
