using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcceso
{
    internal interface IRegistroCuentas
    {
        void AgregarCuenta(int numeroCuenta, string NombrePropietario);
        List<string> obtenerRegistroCuentas();
    }
}
