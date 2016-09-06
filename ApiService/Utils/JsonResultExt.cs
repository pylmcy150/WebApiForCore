using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiService.Utils
{
    public class JsonResultExt
    {
        public JsonResultStatus Code { get; protected set; }

        public object Token { get; protected set; }

        public object Value { get; protected set; }


        public JsonResultExt(object obj)
        {
            Value = obj;
            Code = JsonResultStatus.Success;
        }

        public JsonResultExt(JsonResultStatus code, object obj) :
            this(obj)
        {
            Code = code;
        }

        public JsonResultExt(JsonResultStatus code, object obj, object token) :
            this(code, obj)
        {
            Token = token;
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
