namespace ConsoleApp2
{
    public class Camion : Vehiculo
    {
        private double CapacidadCarga;

        public Camion(string marca, string modelo, int año, double capacidadCarga)
            : base(marca, modelo, año)
        {
            CapacidadCarga = capacidadCarga;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Capacidad de carga: {CapacidadCarga} toneladas");
        }
    }
}