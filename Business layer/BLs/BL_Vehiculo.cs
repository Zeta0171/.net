using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using Business_layer.IBLs;
using DAL.IDALs;
using DAL.Models;
using Shared;


namespace Business_layer.BLs
{
    public class BL_Vehiculo : IBL_Vehiculo
    {
        public readonly IDAL_Vehiculos dal;

        public BL_Vehiculo (IDAL_Vehiculos _dal)
        {
            dal = _dal;
        }

        public Vehiculos AddVehiculo(Vehiculos vehiculo)
        {
            return dal.AddVehiculo(vehiculo);
        }

        public void DeleteVehiculo(long id)
        {
            dal.DeleteVehiculo(id);
        }

        public Vehiculos GetVehiculo(long id)
        {
            return dal.GetVehiculo(id);
        }

        public List<Vehiculos> GetVehiculos()
        {
            return dal.GetVehiculos();
        }

        public Vehiculos UpdateVehiculo(Vehiculos vehiculo)
        {
            return dal.UpdateVehiculo(vehiculo);
        }
    }
}
