using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Carrito
    {
            private IPago _estrategia;

            public void SetEstrategia(IPago estrategia)
            {
                _estrategia = estrategia;
            }

            public void RealizarPago(int monto)
            {
                _estrategia.Pagar(monto);
            }
    }
}
