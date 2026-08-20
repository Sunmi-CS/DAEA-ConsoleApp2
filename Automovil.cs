namespace ConsoleApp2
{
    public class Automovil : Vehiculo
    {
        private string Combustible;

        public Automovil(string marca, string modelo, int año, string combustible)
            : base(marca, modelo, año)
        {
            Combustible = combustible;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Combustible: {Combustible}");
        }
    }
}