using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Data;

namespace Api.Controllers
{
    public class BitcoinController : ApiController
    {
        [HttpPost]
        public async Task<IHttpActionResult> SendBtc([FromBody] SendBtcInfo info)
        {
            return Ok();
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetLast()
        {
            return Ok();
        }
    }
}
