using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IDALs
{
    public interface IDAL_Vehiculos
    {
        Vehiculos AddVehiculo(Vehiculos vehiculo);
        Vehiculos GetVehiculo(long id);
        List<Vehiculos> GetVehiculos();
        Vehiculos UpdateVehiculo(Vehiculos vehiculo);
        void DeleteVehiculo(long id);
    }
}
