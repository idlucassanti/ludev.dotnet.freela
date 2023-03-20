using Ludev.Freela.API.Constants;
using Ludev.Freela.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ludev.Freela.API.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public UsersController(ExempleInjection injection)
        {
            injection.Name = "Request";
        }

        // api/users/1
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        // api/users
        [HttpPost]
        public IActionResult Post([FromBody] CreateUserModel createUser)
        {
            return CreatedAtAction(nameof(GetById), new { id = createUser.Id }, createUser);
        }

        // api/users/1/login
        [HttpPost("{id}")]
        public IActionResult Login([FromBody] UserLoginModel userLogin)
        {
            return Ok();
        }
    }
}
