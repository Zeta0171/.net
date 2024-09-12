using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_layer.IBLs;
using Shared;
using DAL;
using DAL.IDALs;

namespace Business_layer.BLs
{
    public class BL_Personas : IBL_Personas
    {
        private readonly IDAL_Personas dal;

        public BL_Personas(IDAL_Personas _dal)
        {
            dal = _dal;
        }

        public Persona AddPersona(Persona persona)
        {
            return dal.AddPersona(persona);
        }

        public void DeletePersona(long id)
        {
            dal.DeletePersona(id);
        }

        public Persona GetPersona(long id)
        {
            return dal.GetPersona(id);
        }

        public List<Persona> GetPersonas()
        {
            return dal.GetPersonas();
        }

        public Persona UpdatePersona(Persona persona)
        {
            return dal.UpdatePersona(persona);
        }
    }
}
