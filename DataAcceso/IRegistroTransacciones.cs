using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcceso
{
    interface IRegistroTransacciones
    {
        void  AgregarRegistro(int monto);
        List<string> obtenerRegistro();

    }
}
