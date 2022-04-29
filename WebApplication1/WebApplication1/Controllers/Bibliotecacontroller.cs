using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class Bibliotecacontroller
    {
        [ApiController]
        [Route("[controller]/[action]")]
        public class BibliotecaController : ControllerBase
        {
            //Propiedad publica
            public string PropiedadBiblioteca { get; set; }
            public BibliotecaController()
            {
                //constructor
            }
            [HttpGet]
            public string ObtenerLibro()
            {
                return "Obtencion no disponible";
            }

                [HttpPost]
                public string AgregarLibro() 
                {
                    return "No seas Pendejo al agregar ;)";
                }
                [HttpPut]
                public string ActualizarLibro()
                {
                    return "No seas Pendejo al actualizar ;)";
                }

           
        }
    } 
}

