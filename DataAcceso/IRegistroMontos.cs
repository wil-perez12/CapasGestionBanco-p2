using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcceso
{
    interface IRegistroMontos
    {
        void  AgregarRegistroDeposito(int monto);
        List<string> obtenerRegistro();
    }
}
