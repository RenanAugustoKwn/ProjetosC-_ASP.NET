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
        /// <summary>
        /// Autenticacao do usuario
        /// </summary>
        /// <param name="username">Username do usuario</param>
        /// <param name="password">Senha do usuario</param>
        /// <returns>OK</returns>
        [HttpGet]
        public IActionResult Login(string username, string password)
        {
            return Ok(new { response = "Está Logado"});
        }
    }
}
