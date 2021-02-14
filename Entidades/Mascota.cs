using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mascota
    {
        public int IdMascota { get; set; }
        public int IdPropietario { get; set; }
        public int IdTipoEspecie { get; set; }
        public int IdRaza { get; set; }
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Color { get; set; }
    }
}
