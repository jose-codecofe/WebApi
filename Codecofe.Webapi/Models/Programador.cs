using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Codecofe.Webapi.Models
{
    public class Programador
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Especialidad { get; set; }
        public decimal Calificacion { get; set; }
    }
}