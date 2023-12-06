using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_17.Shared.Models
{
    public class Paciente
    {
        public int? id { get; set; }
        public string? nombre { get; set; }
        public string? direccion { get; set; }
        public string? correo { get; set; }
        public string? ns { get; set; }
    }
}
