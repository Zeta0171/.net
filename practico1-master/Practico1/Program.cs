using DAL.DALs;
using DAL.IDALs;
using DAL.Models;
using Shared;

IDAL_Personas dal = new DAL_Personas_Mock();
IDAL_Personas dal2 = new DAL_Personas_ADONET();
IDAL_Personas dalEf = new DAL_Personas_EF();
IDAL_Vehiculos vehiculosDAL = new DAL_Vehiculos_EF();

string comando = "NUEVA";

Console.WriteLine("Bienvenido a mi primera app .NET!!!");
/*
do
{
    Console.WriteLine("Ingrese comando (NUEVA/IMPRIMIR/ELIMINAR/EXIT): ");

    try
    {
        comando = Console.ReadLine().ToUpper();

        switch (comando)
        {
            case "NUEVA":

                Persona persona = new Persona();
                Console.WriteLine("Ingrese el nombre de la persona: ");
                persona.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el documento de la persona: ");
                persona.Documento = Console.ReadLine();
                dal2.AddPersona(persona);
                break;

            case "IMPRIMIR":

                    Console.WriteLine("Ingrese Nombre o Documento:");
                    string filtro = Console.ReadLine();

                    List<Persona> filtradas = 
                        dal.GetPersonas().Where(p => p.Nombre.Contains(filtro) || p.Documento.Contains(filtro))
                                .OrderBy(p => p.Nombre)
                                .ToList();

                    foreach (Persona p in filtradas)
                        Console.WriteLine(p.GetString());

                

                Console.WriteLine("Ingrese el documento de la persona");
                long id = Convert.ToInt64(Console.ReadLine());
                if(id != null)
                {
                    persona = new Persona();
                    persona = dal2.GetPersona(id);
                    Console.WriteLine("La persona es: " + persona.Nombre);
                    Console.WriteLine("Su documento es: " + persona.Documento);
                }
                break;

            case "ELIMINAR":

                Console.WriteLine("Ingrese el id de la persona");
                id = Convert.ToInt64(Console.ReadLine());
                dal2.DeletePersona(id);
                break;

            case "IMPRIMIR TODAS LAS PERSONAS":

                List<Persona> list = new List<Persona>();
                list = dal2.GetPersonas();
                foreach(Persona p in list)
                {
                    Console.WriteLine(p.Id);
                    Console.WriteLine(p.Nombre);
                    Console.WriteLine(p.Documento);
                    Console.WriteLine();
                }
                break;

            case "EDITAR":
                Console.WriteLine("Escriba el id de la persona que desea editar");
                id = Convert.ToInt64(Console.ReadLine());
                Persona per = dal2.GetPersona(id);
                Console.WriteLine("Ingrese el nuevo nombre");
                string nombre = Console.ReadLine();
                per.Documento = nombre;
                dal2.UpdatePersona(per);

                break;
            case "EXIT":
                break;

            default:
                Console.WriteLine("Comando no reconocido.");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
while (comando != "EXIT");
*/
int option = 0;

do
{
    Console.WriteLine("===== MENÚ DE PERSONAS =====");
    Console.WriteLine("1. Agregar Persona");
    Console.WriteLine("2. Eliminar Persona");
    Console.WriteLine("3. Obtener Persona por ID");
    Console.WriteLine("4. Listar Todas las Personas");
    Console.WriteLine("5. Actualizar Persona");
    Console.WriteLine("6. Agregar Vehiculo");
    Console.WriteLine("7. Listar todos los Vehiculo");
    Console.WriteLine("8. Obtener Vehiculo por ID");
    Console.WriteLine("9. Actualizar Vehiculo");
    Console.WriteLine("10. Eliminar Vehiculo");
    Console.WriteLine("0. Salir");
    Console.Write("Seleccione una opción: ");
    option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:
            Persona per = new Persona();
            per.Nombre = Console.ReadLine();
            per.Documento = Console.ReadLine();
            dalEf.AddPersona(per);
            break;
        case 2:
            long id = Convert.ToInt64(Console.ReadLine());
            dalEf.DeletePersona(id);
            break;
        case 3:
            string sId = Console.ReadLine();
            id = Convert.ToInt64(sId);
            per = dalEf.GetPersona(id);
            Console.WriteLine(per.Nombre);
            Console.WriteLine(per.Documento);
            break;
        case 4:
            List<Persona> personas = dalEf.GetPersonas();
            foreach (Persona persona in personas)
            {
                Console.WriteLine(persona.Nombre);
                Console.WriteLine(persona.Documento);
                Console.WriteLine();
            }
            break;
        case 5:
            sId = Console.ReadLine();
            id = Convert.ToInt64(sId);
            Persona perUpdate = new Persona();
            perUpdate = dal.GetPersona(id);
            perUpdate.Nombre = Console.ReadLine();
            perUpdate.Documento = Console.ReadLine();
            dalEf.UpdatePersona(perUpdate);
            break;
        case 6:
            Vehiculos nuevoVehiculo = new Vehiculos();
            Console.Write("Ingrese Marca: ");
            nuevoVehiculo.Marca = Console.ReadLine();
            Console.Write("Ingrese Modelo: ");
            nuevoVehiculo.Modelo = Console.ReadLine();
            Console.Write("Ingrese Matricula: ");
            nuevoVehiculo.Matricula = Console.ReadLine();
            Console.Write("Ingrese ID de la Persona: ");
            nuevoVehiculo.PersonaId = long.Parse(Console.ReadLine());

            vehiculosDAL.AddVehiculo(nuevoVehiculo);
            Console.WriteLine("Vehículo agregado exitosamente.");
            break;
        case 7:
            var vehiculos = vehiculosDAL.GetVehiculos();
            Console.WriteLine("Lista de Vehiculos:");
            foreach (var veh in vehiculos)
            {
                Console.WriteLine($"ID: {veh.Id}, Marca: {veh.Marca}, Modelo: {veh.Modelo}, Matricula: {veh.Matricula}, Persona ID: {veh.PersonaId}");
            }
            break;
        case 8:
            Console.Write("Ingrese el ID del Vehiculo: ");
            id = long.Parse(Console.ReadLine());
            var vehiculo = vehiculosDAL.GetVehiculo(id);

            if (vehiculo != null)
            {
                Console.WriteLine($"ID: {vehiculo.Id}, Marca: {vehiculo.Marca}, Modelo: {vehiculo.Modelo}, Matricula: {vehiculo.Matricula}, Persona ID: {vehiculo.PersonaId}");
            }
            else
            {
                Console.WriteLine("Vehículo no encontrado.");
            }
            break;
        case 9:
            Console.Write("Ingrese el ID del Vehiculo a actualizar: ");
            id = long.Parse(Console.ReadLine());
            vehiculo = vehiculosDAL.GetVehiculo(id);

            if (vehiculo != null)
            {
                Console.Write("Ingrese nueva Marca: ");
                vehiculo.Marca = Console.ReadLine();
                Console.Write("Ingrese nuevo Modelo: ");
                vehiculo.Modelo = Console.ReadLine();
                Console.Write("Ingrese nueva Matricula: ");
                vehiculo.Matricula = Console.ReadLine();
                Console.Write("Ingrese nuevo ID de la Persona: ");
                vehiculo.PersonaId = long.Parse(Console.ReadLine());

                vehiculosDAL.UpdateVehiculo(vehiculo);
                Console.WriteLine("Vehículo actualizado exitosamente.");
            }
            else
            {
                Console.WriteLine("Vehículo no encontrado.");
            }
            break;
        case 10:
            Console.Write("Ingrese el ID del Vehiculo a eliminar: ");
            id = long.Parse(Console.ReadLine());
            vehiculosDAL.DeleteVehiculo(id);
            Console.WriteLine("Vehículo eliminado exitosamente.");
            break;
        case 0:
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("Opción no válida. Intente de nuevo.");
            break;
    }

    Console.WriteLine();
} while (option != 0);

Console.WriteLine("Hasta luego!!!");
Console.ReadLine();

