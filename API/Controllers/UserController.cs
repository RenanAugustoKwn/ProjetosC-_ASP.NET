using Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
            if(user.password == "123")
            {
                return Ok(new { response = "OK" });
            }
            else return Ok(new { response = "Erro Senha Errada" });
        }
    }
}
