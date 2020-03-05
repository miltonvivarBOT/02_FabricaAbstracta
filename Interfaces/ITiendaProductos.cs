using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFabricaAbstracta.Interfaces
{
    interface ITiendaProductos
    {
        ILaptop GenerarInstanciaLaptop();
        IImpresora GenerarInstanciaImpresora();
    }
}
