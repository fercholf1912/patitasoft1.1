using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Entidades
{
    public class ControlMascota
    {
        public int IdControlMascota { get; set; }
        public int IdMascota { get; set; }
        public int IdUsuario { get; set; }
        public decimal Peso { get; set; }
        public decimal Talla { get; set; }
        public string Foto { get; set; }
        public string Observacion { get; set; }
        public DataTable Vacuna { get; set; }

    }
}
