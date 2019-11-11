using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace AccountAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        ConfigSettings configSettings { get; set; }

        public AccountController(IOptions<ConfigSettings> settings)
        {
            configSettings = settings.Value;
        }
        public IActionResult Index()
        {
            return Content(configSettings.Message);
        }

        // POST api/values
        [HttpPost]
        public ActionResult<string> Register([FromBody] string value)
        {
            return "Register Account.";
        }

        // POST api/values
        [HttpPost]
        public ActionResult<string> Update([FromBody] string value)
        {
            return "Update Account Info.";
        }

        // POST api/values
        [HttpPost]
        public ActionResult<string> Close([FromBody] int id)
        {
            return "Close  customer account.";
        }
    }
}
