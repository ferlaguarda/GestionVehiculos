using System.Text.Json;
using Entities;
using Managers;
using System.IO;
using System.Collections.Generic;

Console.WriteLine("Hello, World!");
var c = new GestorVehiculo().LeerVehiculos();
foreach (var item in c)
{
    Console.WriteLine($"Id: {item.Id}, Marca: {item.Marca}, Modelo: {item.Modelo}, Año: {item.Anio}, Matrícula: {item.Matricula}");
}




