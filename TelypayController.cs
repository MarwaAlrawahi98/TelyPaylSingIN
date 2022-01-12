using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication3.Controllers
{
    public class TelypayController : ApiController
    {
        // GET: api/Telypay
        [HttpGet]
        [Route("api/SignIN/{userName}/{password}")]
        public IHttpActionResult SignIN(string userName, string password)
        {
            if (userName.Equals("telypay"))
            {
                if (password.Equals("password123"))
                {

                    return Ok("Success");
                }
                else
                {
                    return BadRequest("Wrong Password");
                }
            }

            return InternalServerError(new Exception("error"));

        }
    }
}
