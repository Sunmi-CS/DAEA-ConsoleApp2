using ConsoleApp2;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Flota
    {
        private List<Vehiculo> vehiculos;

        public Flota()
        {
            vehiculos = new List<Vehiculo>();
        }

        public void AgregarVehiculo(Vehiculo vehiculo)
        {
            vehiculos.Add(vehiculo);
        }

        public void MostrarFlota()
        {
            Console.WriteLine("\n===== INFORMACIÓN DE LA FLOTA =====");

            foreach (Vehiculo vehiculo in vehiculos)
            {
                vehiculo.MostrarInformacion();
                Console.WriteLine("----------------------------");
            }
        }
    }
}