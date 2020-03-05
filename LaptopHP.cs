using PatronFabricaAbstracta.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFabricaAbstracta
{
    class LaptopHP : ILaptop
    {
        public decimal CalcularImporte(int iCantidad)
        {
            return (iCantidad * 5700.00M) * 1.16M;
        }

        public int ObtenerDiasEntrega()
        {
            return 3;
        }
    }
}
