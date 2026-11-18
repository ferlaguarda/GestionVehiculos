using Entities;
using System.Text.Json;

namespace Managers
{
    public class GestorVehiculo
    {
        public int AgregarVehiculo(Vehiculo vehiculo)
        {
            var vehiculos = LeerVehiculos();
            //vehiculo.Id = ObtenerUltimoId(vehiculos);
            vehiculos.Add(vehiculo);

            var json = JsonSerializer.Serialize(vehiculos);
            var path = "C:\\Temporales\\Task.Files\\vehiculos.json";
            try
            {
                File.WriteAllText(path, json);
            }
            catch (Exception)
            {
                return 0;
            }
            return vehiculo.Id;
        }

        public bool EliminarVehiculo(int id)
        {
            var vehiculos = LeerVehiculos();
            var autosActuales = vehiculos.Where(v => v.Id != id).ToList();
            var json = JsonSerializer.Serialize(autosActuales);
            var path = "C:\\Temporales\\Task.Files\\vehiculos.json";
            try
            {
                File.WriteAllText(path, json);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public int ObtenerUltimoId(List<Vehiculo>? listaVehiculos)
        {
            if (listaVehiculos is null)
                listaVehiculos = LeerVehiculos();

            if (listaVehiculos.Count == 0)
                return 1;
            else
                return listaVehiculos.Max(v => v.Id) + 1;
        }

        public List<Vehiculo> LeerVehiculos()
        {
            List<Vehiculo> vehiculos = [];
            var path = "C:\\Temporales\\Task.Files\\vehiculos.json";
            if (File.Exists(path))
            {
                var content = File.ReadAllText(path);
                vehiculos = JsonSerializer.Deserialize<List<Vehiculo>>(content) ?? [];
            }
            return vehiculos;
        }

        public bool ActualizarVehiculo(Vehiculo vehiculo)
        {
            var vehiculos = LeerVehiculos();
            var index = vehiculos.FindIndex(v => v.Id == vehiculo.Id);
            if (index == -1)
                return false;
            vehiculos[index] = vehiculo;
            var json = JsonSerializer.Serialize(vehiculos);
            var path = "C:\\Temporales\\Task.Files\\vehiculos.json";
            try
            {
                File.WriteAllText(path, json);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
