using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TokenBasedAuthenticationWithOwin.Models;

namespace TokenBasedAuthenticationWithOwin.Controllers
{
    [RoutePrefix("api/orders")]
    public class OrderController : ApiController
    {
        [Authorize]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(Order.CreateOrders());
        }
    }
}
