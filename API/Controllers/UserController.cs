using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController, Route("api/[controller]")]
    [Consumes("application/json")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult Login(string username, string password)
        {
            return Ok(new { response = "Está Logado"});
        }
    }
}
