using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.IDALs;
using DAL.Models;

namespace DAL.DALs
{
    public class DAL_Vehiculos_EF : IDAL_Vehiculos
    {
        public Vehiculos AddVehiculo(Vehiculos vehiculo)
        {
            using (var context = new DBContext())
            {
                context.Vehiculos.Add(vehiculo);
                context.SaveChanges();
                return vehiculo;
            }
        }

        public Vehiculos GetVehiculo(long id)
        {
            using (var context = new DBContext())
            {
                return context.Vehiculos.FirstOrDefault(v => v.Id == id);
            }
        }

        public List<Vehiculos> GetVehiculos()
        {
            using (var context = new DBContext())
            {
                return context.Vehiculos.ToList();
            }
        }

        public Vehiculos UpdateVehiculo(Vehiculos vehiculo)
        {
            using (var context = new DBContext())
            {
                var existingVehiculo = context.Vehiculos.FirstOrDefault(v => v.Id == vehiculo.Id);

                if (existingVehiculo != null)
                {
                    existingVehiculo.Marca = vehiculo.Marca;
                    existingVehiculo.Modelo = vehiculo.Modelo;
                    existingVehiculo.Matricula = vehiculo.Matricula;
                    existingVehiculo.PersonaId = vehiculo.PersonaId;

                    context.SaveChanges();
                }

                return existingVehiculo;
            }
        }

        public void DeleteVehiculo(long id)
        {
            using (var context = new DBContext())
            {
                var vehiculo = context.Vehiculos.FirstOrDefault(v => v.Id == id);

                if (vehiculo != null)
                {
                    context.Vehiculos.Remove(vehiculo);
                    context.SaveChanges();
                }
            }
        }
    }
}