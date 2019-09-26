using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Gurps.Net.Api.Controllers.V1.CORE
{
    [Produces("application/json")]
    [Route("api/gurps.net/v1")]
    public class UserController : Controller
    {
        [HttpGet]
        [Route("users")]
        public async Task<IActionResult> GetUsers()
        {
            return Ok(await Task.FromResult("Got it"));
        }
    }
}