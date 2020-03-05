using PatronFabricaAbstracta.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFabricaAbstracta
{
    class ImpresoraDell : IImpresora
    {
        public decimal CalcularImporte(int iCantidad)
        {
            return (iCantidad * 6150.00M) * 1.15M;
        }

        public int ObtenerDiasEntrega()
        {
            return 5;
        }
    }
}
