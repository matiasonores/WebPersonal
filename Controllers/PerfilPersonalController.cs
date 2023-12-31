using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WebPersonal.BackEnd.Controllers
{
    // [Route("api/[controller]")]
    [ApiController]
    public class PerfilPersonalController : ControllerBase
    {
        [HttpGet("LeerPerfil/{id}")]
        public string Get(int id)
        {
            //Codigo para leer de la base de datos

            return id switch
            {
                1 => "Matias",
                2 => "Curso",
                _ => throw new NotSupportedException("el ido no es válido")

            };
        }

        [HttpPost]
        public string Post(PerfilPersonalDto perfilPersonal)
        {
            //Guardar perfil en la base de datos

            return perfilPersonal.Nombre;
        }
    }

    public class PerfilPersonalDto
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
