using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrehistoricKingdom_API.Models
{
    public class Especie
    {
        public int IdEspecie { get; set; }
        public string Nombre { get; set; }
        public string Significado { get; set; }
        public string Dieta { get; set; }
        public string Peso { get; set; }
        public string Periodo { get; set; }
        public string Hallazgo { get; set; }
        public string Dimensiones { get; set; }
        public string Descripcion { get; set; }
        public string Tiempo { get; set; }
        public string Imagen { get; set; }
    }
}