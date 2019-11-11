using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TransactionAPI.Models;

namespace TransactionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public ActionResult<string> Post([FromBody] string value)
        {
            return "value";
        }

        [HttpGet("balance")]
        public ActionResult<string> Balance()
        {
            return "return current balance in account.";

        }

        [HttpPost("deposit")]
        public ActionResult<string> Deposit([FromBody] TransactionModel accountTransactionModel)
        {
            return "deposit amount in account.";
        }

        [HttpPost("withdraw")]
        public ActionResult<string> Withdraw([FromBody] TransactionModel accountTransactionModel)
        {
            return "deposit amount in account.";

        }
    }
}