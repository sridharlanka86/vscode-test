using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace selfReturn.Controllers
{
    [Route("api/returns")]
    [ApiController]
    public class ReturnsController : ControllerBase
    {
        // GET api/returns
        [HttpGet, Route("")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Hello", "Returns" };
        }
    }
}
