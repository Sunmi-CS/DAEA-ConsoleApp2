namespace ConsoleApp2
{
    public class Vehiculo
    {
        private string Marca;
        private string Modelo;
        private int Año;

        public Vehiculo(string marca, string modelo, int año)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Año: {Año}");
        }
    }
}