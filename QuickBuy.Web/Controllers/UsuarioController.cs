using Microsoft.AspNetCore.Mvc;
using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;

namespace QuickBuy.Web.Controllers
{
    [Route("api/[Controller]")]
    public class UsuarioController: Controller
    {

        [HttpGet]
        public ActionResult Get()
        {

            try
            {
                return Ok();
            }
            catch (Exception)
            {

                throw;
            }

        }

        [HttpPost("VerificarUsuario")]
        public ActionResult VerificarUsuario([FromBody]Usuario usuario)
        {

            try
            {
                if (usuario.Email == "adielson")
                    return Ok(usuario);

                return BadRequest("Usuário ou senha inválido");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.ToString());
            }

        }




        [HttpPost]
        public ActionResult Post() {

            try
            {
                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        
        }
    }
}
