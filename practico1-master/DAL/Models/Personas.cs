using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Personas
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long Id { get; set; }
        public string Nombre { get; set; } = "";

        public string Documento { get; set; } = "";


        public Persona GetEntity()
        {
            return new Persona()
            {
                Id = Id,
                Nombre = Nombre,
                Documento = Documento
            };
        }

        public static Personas FromEntity(Persona persona)
        {
            return new Personas()
            {
                Id = persona.Id,
                Nombre = persona.Nombre,
                Documento = persona.Documento
            };
        }
    }


}
