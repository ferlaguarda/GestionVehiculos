namespace Entities
{
    public class Vehiculo
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string? Modelo { get; set; }
        public int Anio { get; set; }
        public string? Matricula { get; set; }

        public Vehiculo(int id, string marca, string? modelo, int anio, string? matricula)
        {
            Id = id;
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
            Matricula = matricula;
        }
    }
}
