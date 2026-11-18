using Entities;
using Microsoft.Data.SqlClient;
using System.Text.Json;

namespace Managers
{
    public class GestorVehiculoDb
    {
        private string CONNECTION_STRING =
            "Data Source=localhost;Initial Catalog=AutoMotor;Integrated Security=True;Trust Server Certificate=True";

        public int AgregarVehiculo(Vehiculo vehiculo)
        {
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Vehiculo (Id,Marca, Modelo, Anio, Matricula) " +
                    "VALUES (@Id, @Marca, @Modelo, @Anio, @Matricula)", connection);
                command.Parameters.AddWithValue("@Id", vehiculo.Id);
                command.Parameters.AddWithValue("@Marca", vehiculo.Marca);
                command.Parameters.AddWithValue("@Modelo", vehiculo.Modelo);
                command.Parameters.AddWithValue("@Anio", vehiculo.Anio);
                command.Parameters.AddWithValue("@Matricula", vehiculo.Matricula);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al conectar a la base de datos: {ex.Message}");
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
            return vehiculo.Id;
        }

        public bool EliminarVehiculo(int id)
        {
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Vehiculo WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al conectar a la base de datos: {ex.Message}");
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
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
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Vehiculo", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(reader.GetOrdinal("Id"));
                    string marca = reader.GetString(reader.GetOrdinal("Marca"));
                    string modelo = reader.GetString(reader.GetOrdinal("Modelo"));
                    int anio = reader.GetInt32(reader.GetOrdinal("Anio"));
                    string matricula = reader.GetString(reader.GetOrdinal("Matricula"));
                    Vehiculo vehiculo = new Vehiculo(id, marca, modelo, anio, matricula);
                    vehiculos.Add(vehiculo);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error al conectar a la base de datos: {ex.Message}");
                return vehiculos;
            }
            finally
            {
                if(connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
            return vehiculos;
        }

        public bool ActualizarVehiculo(Vehiculo vehiculo)
        {
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Vehiculo SET Marca = @Marca, Modelo = @Modelo, Anio = @Anio, Matricula = @Matricula WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", vehiculo.Id);
                command.Parameters.AddWithValue("@Marca", vehiculo.Marca);
                command.Parameters.AddWithValue("@Modelo", vehiculo.Modelo);
                command.Parameters.AddWithValue("@Anio", vehiculo.Anio);
                command.Parameters.AddWithValue("@Matricula", vehiculo.Matricula);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al conectar a la base de datos: {ex.Message}");
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
            return true;
        }
    }
}
