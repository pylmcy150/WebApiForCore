using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using ApiService.Utils;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiService.Controllers
{
    //[Route("api/[controller]")]
    public class ValuesController : Controller
    {
        [HttpGet]
        public string Testx(string id)
        {
            throw new IndexOutOfRangeException(id);
            return Newtonsoft.Json.JsonConvert.SerializeObject(id);
        }

        [HttpGet]
        //[Route("Test")]
        public object Test()
        {
            return new { name = "123", age = 1 };
        }

        [HttpGet()]
        //[Route("Test/{id}")]
        public JsonResultExt GetTest(string id)
        {
            return new JsonResultExt(JsonResultStatus.Success, new { name = id, age = 1 });
            //return Ok(new { name = id, age = 1 });
            //return base.BadRequest("123");
        }

        //[HttpGet()]
        //[Route("Json/{id}")]
        //public string GetJsonp(string id)
        //{
        //    if (Request.QueryString != null)
        //    {
        //        string jsonpCallback = Request.QueryString;
        //        var user = new User
        //        {
        //            Name = name,
        //            Email = email
        //        };

        //        return jsonpCallback + "(" + new JavaScriptConvert.Serialize(user) + ")";
        //    }

        //    return "error";
        //}



        //public IActionResult GetTestFile()
        //{
        //    //return new Utils.FileResult(fileDownloadName, filePath, contentType);
        //    return File()
        //}

        //public virtual FileResult File(string fileDownloadName, string filePath, string contentType = "application/octet-stream")
        //{
        //    return new FileResult(fileDownloadName, filePath, contentType);
        //}

        //public ActionResult ReadMe()
        //{
        //    return File("readme.txt", _appEnvironment.ApplicationBasePath + "\\a.txt");
        //}



        [HttpPost()]
        [Route("Test/{id}")]
        public object PostTest(string id)
        {
            return new { name = id, age = 1 };
        }

        //// GET: api/values
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    throw new HttpResponseException(HttpStatusCode.InternalServerError);
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //[HttpGet("/test}")]
        //public object Test()
        //{
        //    return new { name = "123", age = 1 };
        //}

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
