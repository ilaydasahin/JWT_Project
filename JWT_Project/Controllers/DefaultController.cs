
using Jwt_Example.Models;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jwt_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {

        [HttpGet("[action]")]
        public IActionResult Login()
        {
            return Created("", new BuildToken().CreateToken());
        }
        [Authorize]
        [HttpGet("[action]")]
        public IActionResult CustomerList()
        {
            return Ok("Müşteri Listesine Eriştiniz.");
        }
    }
}