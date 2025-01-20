using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicaNegocios
{
    interface IGestionDepositosRetiros
    {
        void AgregarSaldo(int monto);
        void RetirarMonto(int monto);

    }
}
