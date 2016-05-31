using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace AngularJSAuthentication.Controllers
{
    public class OrdersController : ApiController
    {

        // POST api/Orders/GetName
        [Authorize]
        [Route("api/Orders/GetName")]
        public async Task<IHttpActionResult> GetName()
        {
            return Ok("neeraj");
        }
    }
}
