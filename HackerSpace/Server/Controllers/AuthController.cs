using Duende.IdentityServer.Extensions;
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
            if (User.IsAuthenticated())
            {
                return "Authorized On Server";
            }
            else
            {
                return "Not Authorized On Server";
            }
        }
    }
}
