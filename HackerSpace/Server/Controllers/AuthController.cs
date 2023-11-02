using Duende.IdentityServer.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HackerSpace.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        
        [HttpGet]
        public string Get()
        {
            if(User.IsInRole("Admin"))
            {
                return "Authorized as Admin On Server";
            }
            if (User.IsAuthenticated())
            {
                return "Authorized On Server";
            }
            else
            {
                return "Not Authorized On Server";
            }
        }

        [HttpGet]
        [Route("admin")]
        [Authorize(Roles = "Admin")]
        public string AdminGet()
        {
            return "Only accessible by admin";
        }
    }
}
