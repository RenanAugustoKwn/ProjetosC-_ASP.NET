using Common;
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
        /// <param name="user">Username e Senha do usuario</param>
        /// <returns>OK</returns>
        [HttpPost]
        public IActionResult Login(UserModel user)
        {
            return Ok(new { response = "Está Logado"});
        }
    }
}
