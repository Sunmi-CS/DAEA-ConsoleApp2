
using ConsoleApp2;
using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();

            Automovil auto = new Automovil(
                "Toyota",
                "Corolla",
                2022,
                "Gasolina"
            );

            Camion camion = new Camion(
                "Volvo",
                "FH",
                2020,
                20.5
            );

            vehiculos.Add(auto);
            vehiculos.Add(camion);

            Flota flota = new Flota();

            flota.AgregarVehiculo(auto);
            flota.AgregarVehiculo(camion);

            int opcion;

            do
            {
                Console.Clear();

                Console.WriteLine("=================================");
                Console.WriteLine("       SISTEMA DE VEHÍCULOS");
                Console.WriteLine("=================================");
                Console.WriteLine("1. Mostrar información de vehículos");
                Console.WriteLine("2. Calcular costo de viaje");
                Console.WriteLine("3. Salir");
                Console.WriteLine("=================================");

                opcion = LeerEntero("Seleccione una opción: ");

                switch (opcion)
                {
                    case 1:
                        flota.MostrarFlota();
                        Pausar();
                        break;

                    case 2:
                        CalcularCostoViaje(vehiculos);
                        Pausar();
                        break;

                    case 3:
                        Console.WriteLine("\nSaliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("\nOpción inválida.");
                        Pausar();
                        break;
                }

            } while (opcion != 3);
        }

        static int LeerEntero(string mensaje)
        {
            int numero;

            while (true)
            {
                Console.Write(mensaje);

                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    return numero;
                }

                Console.WriteLine("Error: debe ingresar un número entero.");
            }
        }

        static double LeerDouble(string mensaje)
        {
            double numero;

            while (true)
            {
                Console.Write(mensaje);

                if (double.TryParse(Console.ReadLine(), out numero))
                {
                    return numero;
                }

                Console.WriteLine("Error: debe ingresar un número válido.");
            }
        }

        static void CalcularCostoViaje(List<Vehiculo> vehiculos)
        {
            Console.Clear();

            Console.WriteLine("===== CALCULAR COSTO DE VIAJE =====");

            Console.WriteLine("\nVehículos disponibles:");

            for (int i = 0; i < vehiculos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Vehículo {i + 1}");
            }

            int seleccion;

            while (true)
            {
                seleccion = LeerEntero("\nSeleccione un vehículo: ");

                if (seleccion >= 1 && seleccion <= vehiculos.Count)
                {
                    break;
                }

                Console.WriteLine("Error: seleccione un vehículo válido.");
            }

            double distancia = LeerDouble("Ingrese la distancia del viaje en km: ");

            double costoPorKm = 2.50;

            double costoTotal = distancia * costoPorKm;

            Console.WriteLine("\n===== RESULTADO =====");
            Console.WriteLine($"Vehículo seleccionado: {seleccion}");
            Console.WriteLine($"Distancia: {distancia} km");
            Console.WriteLine($"Costo por km: S/ {costoPorKm:F2}");
            Console.WriteLine($"Costo total: S/ {costoTotal:F2}");
        }

        static void Pausar()
        {
            Console.WriteLine("\nPresione ENTER para continuar...");
            Console.ReadLine();
        }
    }
}