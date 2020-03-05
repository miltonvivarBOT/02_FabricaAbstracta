using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFabricaAbstracta.Interfaces
{
    interface ILaptop
    {
        decimal CalcularImporte(int iCantidad);
        int ObtenerDiasEntrega();
    }
}
