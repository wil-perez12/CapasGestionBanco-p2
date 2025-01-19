
namespace DataAcceso
{
    public class GestionBancoData : IRegistroMontos
    {
        public List<string> registro { get; set; }

        public GestionBancoData()
        {
            registro = new List<string>();
        }



        // metodo para agregar monto depositados a una lista
        public void AgregarRegistroDeposito(int monto)
        {
            registro.Add($"{monto}");
        }

        //metodo para mostrar esa lista
        public List<string> obtenerRegistro()
        {
            Console.WriteLine("Historial de montos depositados");
            foreach (var montos in registro)
            {
                Console.WriteLine(montos);
            }
            return registro;
        }
    }
}
