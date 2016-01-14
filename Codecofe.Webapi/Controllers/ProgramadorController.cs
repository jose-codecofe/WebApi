/*
 *  CodeCofe.com
 * 
 *  contact@codecofe.com  
 *  +591 72483556 
 * 
 */
using Codecofe.Webapi.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace Codecofe.Webapi.Controllers
{
    // Nota: referenciar herencia a ApiController.
    public class ProgramadorController : ApiController
    {
        public IEnumerable<Programador> GetProgramadores()
        {
            List<Programador> programadores = new List<Programador>();

            programadores.Add(new Programador { ID = 1, Nombre = "Pedro", Apellido = "Martinez", Especialidad = ".NET", Calificacion = 99.56m });
            programadores.Add(new Programador { ID = 2, Nombre = "Luis", Apellido = "Rocha", Especialidad = "JAVA", Calificacion = 93.22m });
            programadores.Add(new Programador { ID = 3, Nombre = "Ricardo", Apellido = "Alvarez", Especialidad = "RUBY", Calificacion = 98.24m });
            programadores.Add(new Programador { ID = 4, Nombre = "Rodrigo", Apellido = "Montes", Especialidad = ".NET", Calificacion = 88.33m });

            return programadores;
        }

    }
}