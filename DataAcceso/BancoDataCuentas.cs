using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcceso
{
    class BancoDataCuentas : IRegistroCuentas
    {
        public List<string> registro { get; set; }

        public BancoDataCuentas()
        {
            registro = new List<string>();
        }


        //metodo para agregar cuenta y nombre del propietario a una lista
        public void AgregarCuenta(int numeroCuenta, string NombrePropietario)
        {
            registro.Add($"{NombrePropietario} su numero de cuenta es {numeroCuenta}");
        }

        public List<string> obtenerRegistroCuentas()
        {
            Console.WriteLine("Registro de cuentas de banco:");

            foreach (var cuentas in registro)
            {
                Console.WriteLine($"- {cuentas}");
            }

            return registro;
        }
    }
}
