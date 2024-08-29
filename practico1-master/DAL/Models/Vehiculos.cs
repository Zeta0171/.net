using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace DAL.Models
{
    public class Vehiculos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long Id { get; set; }

        public string Marca { get; set; } = "";

        public string Modelo { get; set; } = "";

        public string Matricula { get; set; } = "";

        [ForeignKey("PersonaId")]
        public long PersonaId { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
