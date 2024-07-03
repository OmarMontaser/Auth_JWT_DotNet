using AuthJWT.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AuthJWT.Controllers
{
    [Authorize(Roles = "User")]
    public class HomeController : ControllerBase
    {

        [HttpGet("Test")]
        public async Task<IActionResult> getdata()
        {
            return Ok("Databvfghnngggdata");
        }

    }
}
