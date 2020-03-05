using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFabricaAbstracta.Interfaces
{
    interface IImpresora
    {
        decimal CalcularImporte(int iCantidad);
        int ObtenerDiasEntrega();
    }
}
