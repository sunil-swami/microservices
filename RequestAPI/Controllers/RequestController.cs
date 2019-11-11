using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RequestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // POST api/values
        [HttpPost]
        public ActionResult<string> RequestCheckBook([FromBody] string value)
        {
            return "Request CheckBook";
        }

        // POST api/values
        [HttpPost]
        public ActionResult<string> BlockCheckBook([FromBody] string value)
        {
            return "Block CheckBook.";
        }

    }
}