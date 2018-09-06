using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Challenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class CountController : ControllerBase
    {
        [AcceptVerbs("POST")]
        public ActionResult<int> CountResult([FromBody]string value)
        {
            int toReturn = value.Count();
            return toReturn;
        }
    }
}