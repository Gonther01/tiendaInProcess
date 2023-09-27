using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Persona:BaseEntity
    {
        public string Nombre { get; set; }
        public string FechaRegistro { get; set; }
        public ICollection<UbicacionPersona> UbicacionesPersonas { get; set; }
    }
}