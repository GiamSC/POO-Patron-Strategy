using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
        if(tipo_Pago == "tarjeta") ...
        else if(tipo_Pago == "efectivo") ... 
 */
namespace ConsoleApp1
{
    // Strategy
    public interface IPago
    {
        void Pagar(int monto);
    }

    // Estrategias concretas
    public class PagoTarjeta : IPago
    {
        public void Pagar(int monto)
        {
            Console.WriteLine("Pagando con tarjeta: " + monto);
        }
    }

    public class PagoEfectivo : IPago
    {
        public void Pagar(int monto)
        {
            Console.WriteLine("Pagando en efectivo: " + monto);
        }
    }

    
}
