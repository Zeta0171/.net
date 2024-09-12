using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Vehiculo
    {
        public long Id { get; set; }

        public string Marca { get; set; } = "";

        public string Modelo { get; set; } = "";

        public string Matricula { get; set; } = "";

        public long PersonaId { get; set; }

        public virtual Persona Persona { get; set; } = new Persona();
    }
}
